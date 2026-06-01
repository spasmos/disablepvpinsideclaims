# Titulo

DisablePvPInsideClaims

## Descripcion Corta

Un mod ligero server-side para Vintage Story que desactiva el dano jugador contra jugador dentro de zonas reclamadas.

## Descripcion Larga

`DisablePvPInsideClaims` es un pequeno mod server-side para Vintage Story 1.22.x.

Mantiene el PvP activado de forma global, pero impide que los jugadores hagan dano a otros jugadores cuando el atacante o la victima estan dentro de un claim. Esto permite usar las zonas reclamadas como areas protegidas sin desactivar el combate survival en el resto del mundo.

El mod esta pensado para ser muy concreto:

- Solo se ejecuta en el servidor
- Los clientes no necesitan instalarlo
- No anade comandos ni archivos de configuracion
- Solo bloquea dano jugador contra jugador dentro de zonas reclamadas
- No bloquea que los jugadores ataquen criaturas, drifters, animales u otros enemigos no jugadores dentro de claims

La regla comprueba ambos lados del ataque. Si la victima esta dentro de un claim, queda protegida. Si el atacante esta dentro de un claim, no puede usar esa zona protegida como posicion segura para atacar a jugadores fuera de ella.

## Instrucciones de Uso

1. Instala el mod en el servidor.
2. Reinicia el servidor.
3. Manten el PvP global activado en la configuracion del servidor si quieres PvP fuera de claims.
4. Cualquier claim actuara como zona sin PvP para dano jugador contra jugador.

No requiere configuracion.

Compatibilidad:

- Vintage Story `1.22.x`

## Changelog 1.0.0

- Primera version server-side
- Anadida proteccion contra dano jugador contra jugador dentro de claims
- Bloquea ataques cuando atacante o victima estan dentro de un claim
- Mantiene intacto el combate jugador contra criaturas
- Compilado contra la API de Vintage Story 1.22.x
