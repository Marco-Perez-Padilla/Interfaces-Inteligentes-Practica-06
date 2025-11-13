# Interfaces-Inteligentes-Practica-06

En esta práctica se experimenta con XR Interaction Toolkit (sin simulador), previa configuración de:
- XR Management (XR Plugin Management)
- OpenXR Plugin
- XR Interaction Toolkit
- Meta XR Core SDK
- Meta XR Simulator

---

### 1. Interacción básica - Selección de cubos

Agrega en la escena dos cubos sobre un plano, uno lejano y otro cercano. 
El lejano será un Ray Interactor que cambia de color al seleccionarlo. El cercano será un Direct Interactor que muestra un mensaje en consola al agarrarlo

Se ha solucionado utilizando los componentes de XR Origin y los mandos reales del visor, de modo que el cubo cercano se podría agarrar directamente y el cubo lejano se selecciona con el rayo, gestionando los cambios de color y los mensajes en consola mediante scripts.
Sin embargo, en el GIF de la solución, ambos cubos han sido seleccionados mediante rayos.

**Scripts:**  
- [ColourOnSelect.cs](Scripts/ColourOnSelect.cs)  
- [MessageOnGrab.cs](Scripts/MessageOnGrab.cs)  


![GIF](Gifs/GIF-E-15.gif)


Como resultado de este ejercicio, se ha generado la siguiente apk:
- [APK](apk/Practica-05.apk)
