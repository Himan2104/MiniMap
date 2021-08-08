# MiniMap
MiniMap utility for Unity. Easy to scale and Modify.

# Usage
- Clone repo/install package.
- Drag the Minimap/Minimap.prefab onto your canvas.
- Add "PlayerTracker.cs" script to your player object.
- Add "DestinationTracker.cs" script to your destination object(s).
- Voila.

# Scaling
The Range and Scale variables in the inspector are required to be configured in the following way:
- Range is the real world space range you want to consider inside the map.
- Scale = (Radius of Minimap Canvas Object) / Range.

