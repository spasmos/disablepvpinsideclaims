# DisablePvPInsideClaims

A lightweight server-side Vintage Story mod that disables player-vs-player damage inside land claims.

`DisablePvPInsideClaims` keeps PvP enabled globally, but prevents players from damaging other players when either the attacker or the victim is inside a land claim. This makes claimed areas usable as protected zones without disabling survival combat everywhere else.

The mod is intentionally focused:

- It only runs on the server
- Clients do not need to install it
- It does not add commands or configuration files
- It only blocks player-vs-player damage inside claimed areas
- It does not block players from attacking creatures, drifters, animals, or other non-player enemies inside claims

The rule checks both sides of the attack. If the victim is inside a claim, they are protected. If the attacker is inside a claim, they cannot use the claimed area as a safe position to attack players outside it.

## Usage

1. Install the mod on the server.
2. Restart the server.
3. Keep global PvP enabled in the server configuration if you want PvP outside claims.
4. Any land claim will act as a no-PvP area for player-vs-player damage.

No configuration is required.

## Compatibility

- Vintage Story `1.22.x`

## Changelog 1.0.0

- Initial server-side release
- Added protection against player-vs-player damage inside land claims
- Blocks attacks when either attacker or victim is inside a claim
- Leaves player-vs-creature combat untouched
- Built against the Vintage Story 1.22.x API
