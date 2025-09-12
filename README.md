-¿qué es un GameManager?
    El GameManager es el cerebro del juego. Es un sistema que se encarga de mantener el control general de todo el juego.

-¿De qué se encarga un GameManager?

      Estado del juego completo: Controla si estás en el menú principal, jugando, en pausa,etc
      Manejo de Datos: Guarda información como puntuación, configuraciones, progresos,etc.
      Transiciones: Decide cuándo cambiar de escena.
      Configuraciones globales: Volumen de música, dificultad, idioma, etc.
      Guardado: Guardar y cargar partidas
      Eventos importantes del juego: Como cuando el jugador muere o completa un nivel

-Características del GameManager:

    Sobrevive entre escenas: No se termina cuando cambias de escena
    Único: Solo debería existir uno
    Universal: Otros scripts pueden pedirle información
    Perspectiva: Ve todo el juego como un conjunto, no solo una escena


-¿Qué es un GameController?
  El GameController es el que controla de manera local una escena específica.

-¿De qué se puede encargar un GameController?

Lógica específica : funciones que solo aplican en una escena en particular
Condiciones: ¿Qué necesitas para completar esta escena?
Spawn: Crear enemigos, obstáculos en momentos o lugares específicos
UI local: Mostrar información relevante solo para esa escena
Checkpoints: Puntos de guardado dentro del nivel

Características del GameController:

Específico : Cada escena puede tener su propio GameController
Se destruye al cambiar escena: Su trabajo termina cuando sales de esa escena
Perspectiva local: Solo le importa lo que pasa en su escena
Comunica con GameManager: Le reporta eventos importantes (como "nivel completado")
