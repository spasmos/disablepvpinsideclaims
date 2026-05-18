using HarmonyLib;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace DisablePvPInsideClaims;

public class DisablePvPInsideClaimsModSystem : ModSystem
{
    private Harmony? harmony;
    private ICoreServerAPI? sapi;

    public override void StartServerSide(ICoreServerAPI api)
    {
        sapi = api;
        harmony = new Harmony(Mod.Info.ModID);
        harmony.Patch(
            AccessTools.Method(typeof(EntityPlayer), nameof(EntityPlayer.ShouldReceiveDamage)),
            postfix: new HarmonyMethod(typeof(DisablePvPInsideClaimsModSystem), nameof(ShouldReceiveDamagePostfix)));
    }

    public override void Dispose()
    {
        harmony?.UnpatchAll(Mod.Info.ModID);
        harmony = null;
        sapi = null;
    }

    public static void ShouldReceiveDamagePostfix(
        EntityPlayer __instance,
        DamageSource damageSource,
        ref bool __result)
    {
        if (!__result || __instance.World?.Side != EnumAppSide.Server)
        {
            return;
        }

        if (__instance.Api?.ModLoader.GetModSystem<DisablePvPInsideClaimsModSystem>() is not { } modSystem)
        {
            return;
        }

        if (damageSource == null || damageSource.GetCauseEntity() is not EntityPlayer attacker)
        {
            return;
        }

        if (attacker.EntityId == __instance.EntityId)
        {
            return;
        }

        if (modSystem.IsInsideAnyClaim(attacker) || modSystem.IsInsideAnyClaim(__instance))
        {
            __result = false;
        }
    }

    private bool IsInsideAnyClaim(EntityPlayer player)
    {
        LandClaim[] claims = sapi?.World.Claims.Get(player.Pos.AsBlockPos) ?? Array.Empty<LandClaim>();
        return claims.Length > 0;
    }
}
