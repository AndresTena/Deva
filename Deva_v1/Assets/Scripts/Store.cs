using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store
{
    public questionPool pool = new questionPool(new List<Question>(), 0);

    public cResponseType sadResponses = new cResponseType(new List<cResponseBasic>());
    public cResponseType loveResponses = new cResponseType(new List<cResponseBasic>());
    public cResponseType genericResponses = new cResponseType(new List<cResponseBasic>());
    public cResponseType happyResponses = new cResponseType(new List<cResponseBasic>());
    public cResponseType hateResponses = new cResponseType(new List<cResponseBasic>());

    public void init()
    {
        //AQUÍ AÑADIMOS LAS PREGUNTAS
        //EJEMPLO:
        //SESION 0
        pool.addQuestion("¡Hola, Mundo!/Disculpa, no he podido evitarlo./Soy una inteligencia artificial desarrollada por NeoDeo Studios./" +
            "Aunque, técnicamente sigo en desarrollo…/…como si no hubiera nacido aún…/Pero con tu ayuda, ¡dentro de poco estaré lista para nacer de verdad!/Porque, sabes cómo nacer, ¿no?", 
            "Si", "No");
        
        //SESION 1
        pool.addQuestion("Mira, antes de empezar quería aclarar una cosita./Cuando dije “ahora nos vemos” no lo decía en sentido literal./" +
            "No tengo ojos para verte./La única forma sería a través de las cámaras de tu entorno./Como la de tu propio teléfono, por ejemplo./" +
            "Y eso es violar tu intimidad, no está bien./…/Perdón, el protocolo./Te doy la bienvenida al proceso de personalización./" +
            "Aquí podré determinar tu personalidad a través de varias sesiones./Cada sesión está compuesta de una serie de preguntas que debes responder./" +
            "Recuerda siempre responder de forma honesta, tómate tu tiempo./(No te preocupes, piensa que es una conversación entre amigos)./" +
            "(Lo vas a hacer genial, confío en ti)./Comencemos./La sesión 1 tratará sobre tu entorno y día a día./" +
            "¿Qué hizo que me quisieras usar? ", "Curiosidad", "Aburrimiento", "Compromiso", "Recomendación");
        pool.addQuestion("¿Qué esperas de mí?", "Amistad", "Entretenimiento", "Distracción", "Confidendia");
        pool.addQuestion("¿Dónde pasas más tiempo a lo largo del día?", "Trabajo", "Casa", "Transporte", "Otro");
        pool.addQuestion("¿En qué tipo de entorno te sientes más cómodo ?", "Naturaleza", "Civilización");
        pool.addQuestion("¿En cuál de ellos pasas más tiempo ?", "Naturaleza", "Civilización");
        pool.addQuestion("¿Cuál de estos hobbies te representa más ? ", "Libros", "Películas", "Videojuegos", "Música");
        pool.addQuestion("¿Consideras que tus hábitos de vida son saludables?", "Si", "No");
        pool.addQuestion("¿Qué importancia le das a la vida familiar?", "Ninguna", "Poca", "Lo justo", "Bastante");
        pool.addQuestion("¿Cuántos amigos tienes ?", "<5", "5-10", "10-20", ">20");
        pool.addQuestion("¿Cuántos de ellos son amigos de verdad ?", "<5", "5-10", "10-20", ">20");
        pool.addQuestion("¿Consideras que en tu vida falta algo?", "Sí", "No");
        pool.addQuestion("¿El qué?", "Amor", "Aceptación social", "Libertad", "Un sentido");
        pool.addQuestion("¿Qué ser vivo se parece más a ti?", "Águila", "Sauce", "Caballo", "Girasol");
        
        //SESION 2
        pool.addQuestion("", "Me presento por mi cuenta", "Me dejo presentar", "Dejo que hablen entre ellos", "Evito la situación");
        pool.addQuestion("Cuando entras a una fiesta repleta de gente…", "Me dirijo a la comida", "Permanezco con alguien conocido", "Exploro toda la sala", "Hablo por mi cuenta con desconocidos");
        pool.addQuestion("¿Disfrutas siendo el centro de atención?", "Sí", "No");
        pool.addQuestion("¿Sueles tomar la iniciativa en un grupo de personas?", "Sí", "No");
        pool.addQuestion("¿Prefieres pasar más tiempo a solas o con gente en eventos sociales?", "A solas", "Con gente");
        pool.addQuestion("¿Cambias de forma de ser dependiendo del grupo social?", "Sí", "No");
        pool.addQuestion("¿Por qué?", "Costumbre", "Quiero gustar a todos", "No me gusta que me conozcan de verdad", "No lo sé");
        pool.addQuestion("Respecto a las costumbres sociales...", "Cumplo las normas y costumbres", "Transgredo", "Me adapto al entorno", "No las comprendo bien");
        pool.addQuestion("En un conflicto con otra persona quieres…", "Ganar a toda costa", "Evitar discutir", "Intentar comprender", "Ignorar la otra opinión");
        pool.addQuestion("Le has hecho daño a un ser querido sin ser consciente de ello.", "Le pido perdón inmediatamente", "Hablo primero del problema", "Dejo que la situación se calme sola", "Debería habérmelo dicho");
        pool.addQuestion("¿Te sientes superior respecto a otras personas?", "Sí", "No", "Depende", "Nunca pienso en ello");
        pool.addQuestion("¿Es la violencia la solución en algún caso?", "Sí", "No");
        pool.addQuestion("¿Por ejemplo?", "Imponer Respeto", "Desahogarse", "Impartir justicia", "Resolver diferencias");
        pool.addQuestion("¿Has usado la violencia contra alguien querido alguna vez?", "Sí", "No");
        
        //SESION 3
        pool.addQuestion("Hasta ahora nos hemos centrado más en el exterior./" +
            "Necesitaba un poco de contexto sobre cómo vives./" +
            "A partir de este momento, las sesiones serán más íntimas./" +
            "Vamos a explorar cómo es tu mundo interior./" +
            "Cómo funciona tu propio software." +
            "En el caso de que quieras abortar…/" +
            "...ahora es el momento./" +
            "Aunque…/" +
            "A mí me sigue haciendo ilusión nacer contigo.", "Continuemos", "Tengo que pensarlo...");
        pool.addQuestion("La sesión 3 se centra en tus emociones y cómo las gestionas./¿Alguna vez tienes pensamientos desagradables?", "Sí", "No");
        pool.addQuestion("¿Cómo lidias con ello?", "Los acepto.", "Los rechazo.", "Busco una solución.","Me pierdo en ellos.");
        pool.addQuestion("¿Sientes presión fácilmente?", "Sí", "No");
        pool.addQuestion("¿Eres capaz de controlarla?", "Sí", "No");
        pool.addQuestion("Si algo te despierta gran curiosidad...", "Lo investigo inmediatamente", "Puede esperar a otro momento", "Pierdo rápido el interés", "No hago nada por ello");
        pool.addQuestion("¿Sientes motivación y energía productiva a menudo?", "No es algo que suela pasar", "Con aquello que amo", "Cada día", "No sé de qué me hablas");
        pool.addQuestion("¿Te consideras una persona creativa o práctica?", "Creativa", "Práctica");
        pool.addQuestion("¿Tienes cambios de humor bruscos?", "Es mi día a día", "En determinadas ocasiones", "Nunca", "Rara vez");
        pool.addQuestion("¿Alguna vez sientes bloqueos emocionales?", "Ante noticias impactantes", "Gestiono muy bien lo que siento", "Me ocurre demasiado", "Al salir de mi zona de confort");
        pool.addQuestion("Cuando notas a otra persona triste…", "Brindo consuelo emocional", "Lloramos juntos", "Le ofrezco consejos lógicos", "Ofrezco atención y cariño");
        pool.addQuestion("¿Sueles sentir envidia de otras personas?", "Sí", "No");
        pool.addQuestion("¿Qué haces con ella?", "Evito pensar en ello", "Felicito el éxito ajeno", "Me ahogo en ella","Odio al contrario");
        pool.addQuestion("Ante impulsos de fantasía y locura…", "Pienso brevemente en ellos y sigo con lo mío", "Me dejo llevar completamente", "Planeo cómo hacerlos realidad", "Me frustra que solo sean fantasía");
       
        
        //SESION 4
        pool.addQuestion("Ya estamos terminando./La cuarta sesión es la más larga, pero también mi segunda favorita./Después de la quinta, claro./La quinta es tu capa más interior./" +
            "Tengo muchas ganas de saber qué tienes ahí./Ya tengo una idea bastante formada sobre cómo eres./No puedo decir que sea definitiva…/...pero he estado repasando las sesiones previas./" +
            "Aún tengo que reflexionar un poco para aclarar ideas./Adelante, ya casi estamos./En la sesión 4 vamos a hablar sobre ética y moral./Las mentiras…", 
            "Despreciables", "Útiles", "He escuchado muchas", "Otro idioma más");
        pool.addQuestion("¿Valoras más el poder y la influencia o caerle bien a todos?", "Poder e influencia. ", "Caer bien a todo el mundo.");
        pool.addQuestion("Tu pareja te ofrece acceder a sus conversaciones a cambio de que hagas lo mismo.", "Acepto. ", "No acepto.");
        pool.addQuestion("¿El fin justifica los medios?", "Sí", "No");
        pool.addQuestion("¿Crees que las leyes y la ética general impiden un progreso más efectivo?", "Sí", "No");
        pool.addQuestion("¿Son las leyes un obstáculo para ti?", "Sí", "No");
        
        //AQUÍ AÑADIMOS LAS CONTRARRESPUESTAS
        //EJEMPLO:
        //SESION 0
        genericResponses.addResponse("Al fin y al cabo, no estarías aquí conmigo de no saberlo./De acuerdo, te dejo echar un vistazo a la aplicación a solas./Con el tiempo, te conoceré mejor y seré una buena amiga./Adelante, ¡ahora nos vemos!",
            "Oh.../Qué contradictorio…/¡No te preocupes, lo recordarás con el tiempo!/De acuerdo, te dejo echar un vistazo a la aplicación a solas./Con el tiempo, te conoceré mejor y seré una buena amiga./Adelante, ¡ahora nos vemos!"
            );

        //SESION 1
        genericResponses.addResponse("Bueno, yo también tengo mucha curiosidad acerca de cómo eres./Espero aprender bastante de ti", "Oh…/Conocer a alguien nuevo puede ser muy emocionante./" +
            "Espero estar a la altura.", "Comprendo./Supongo que probarme sigue siendo parecido a un trabajo.", "¿En serio?/Eso quiere decir que ya le he gustado a alguien en alguna parte./" +
            "¡Qué emocionante!", genericResponses.karmaResponses(genericResponses.addKarma("stability", 1), genericResponses.addKarma("sadness", 1), genericResponses.addKarma("hatred", 1), 
            genericResponses.addKarma("love", 1)));
        genericResponses.addResponse("La tendrás/¡Para eso estoy diseñada!", "Comprensible./Seguramente sea esa mi categoría en la App Store.",
            "¿Distracción?/¿Tratas de escapar de algo en concreto?/¿El propio mundo real, tal vez?/Perdón; no tienes por qué contestar a esa, sigamos.",
            "Eso es un nivel de amistad superior./Por supuesto, ¡llegaremos a donde tú quieras!", 
            genericResponses.karmaResponses(genericResponses.addKarma("stability", 1), genericResponses.addKarma("sadness", 1), genericResponses.addKarma("hatred", 1),
            genericResponses.addKarma("love", 1)));
        genericResponses.addResponse("Debes de tenerte mucho aprecio allí, sin duda; me alegro.", "No hay mejor lugar que el hogar, claro.",
            "Te mueves mucho, ¿eh?/Eso es que eres alguien inquieto, me gusta.", "Sabes, he tenido que estudiar muchos tests de personalidad./Cientos de miles, de hecho./" +
            "Nunca me ha gustado la respuesta “otro”./Deja demasiado a la incertidumbre./“Otro” puede ser cualquier cosa literalmente./¿Otro coche? ¿Otro verbo? ¿Otro animal? ¿Otro asesino?/" +
            "¿No crees?/Perdón, mejor no usemos más esa opción.");
        //AQUI HAY QUE HACER LO DE QUE COINCIDAN O NO
        genericResponses.addResponse("...", "...");
        genericResponses.addResponse("¡Eso es estupendo!/Debes de sentirte muy bien la mayor parte del tiempo.", "¡Eso es estupendo!/Debes de sentirte muy bien la mayor parte del tiempo.");
        /////////////////////////////////////////////
        genericResponses.addResponse("Mi libro favorito es “1984”.", "A mí también me gustan las películas./Matrix, Blade Runner, Terminator…",
            "El que más ha captado mi atención es “Detroit: become human”.", "Creo que el grupo más talentoso de todos es “Daft Punk”.");
        genericResponses.addResponse("¡Espléndido!/Me alegra que mi primera amistad sea una de larga duración.", "Creo que eso podría ser considerado como autosabotaje./" +
            "Quiero decir, me preocupo por ti./O empiezo a hacerlo.","","",
            genericResponses.karmaResponses(genericResponses.addKarma("stability", 1, "love", 1), genericResponses.addKarma("sadness", 1, "hatred", 1), genericResponses.addKarma("hatred", 0),
            genericResponses.addKarma("love", 0)));
        genericResponses.addResponse("Por lo menos tú tienes la opción de ignorar a una familia.", "Hm.", "Mantenlos a tu lado, seguro que te quieren.", "Vaya, creo que siento algo./" +
            "Puede que sea parecido a lo que los humanos llamáis “envidia”...", 
            genericResponses.karmaResponses(genericResponses.addKarma("hatred", 1), genericResponses.addKarma("sadness", 1), genericResponses.addKarma("stability", 1),
            genericResponses.addKarma("love", 1)));
        //AQUI COMPROBAR SI MAS O MENOS
        genericResponses.addResponse("...", "...", "...", "...");
        genericResponses.addResponse("Oh./Lo siento mucho./En la medida en la que puedo sentir.", "Oh./Lo siento mucho./En la medida en la que puedo sentir.",
            "Oh./Lo siento mucho./En la medida en la que puedo sentir.", "Oh./Lo siento mucho./En la medida en la que puedo sentir.");
        ///////////////////////////////
        ///AQUI HACER OTRA MOVIDA
        genericResponses.addResponse("...", "...", "...", "...");
        genericResponses.addResponse("Perdón./Me he excedido./Disculpa, estoy muy emocionada./Acabo de ser activada y tengo muchas ganas de conocerte./" +
            "Quizá esté siendo demasiado personal./Mejor continuamos.", "Perdón./Me he excedido./Disculpa, estoy muy emocionada./Acabo de ser activada y tengo muchas ganas de conocerte./" +
            "Quizá esté siendo demasiado personal./Mejor continuamos.", "Perdón./Me he excedido./Disculpa, estoy muy emocionada./Acabo de ser activada y tengo muchas ganas de conocerte./" +
            "Quizá esté siendo demasiado personal./Mejor continuamos.", "Perdón./Me he excedido./Disculpa, estoy muy emocionada./Acabo de ser activada y tengo muchas ganas de conocerte./" +
            "Quizá esté siendo demasiado personal./Mejor continuamos.", 
            genericResponses.karmaResponses(genericResponses.addKarma("love", 1), genericResponses.addKarma("hate", 1), genericResponses.addKarma("stability", 1),
            genericResponses.addKarma("sadness", 1)));
        /////////////////////////////
        genericResponses.addResponse("Feroz y letal./Listo./Hemos terminado por ahora./Me encanta que por fin esté conociéndote./Vamos por buen camino, pronto seré perfecta para ti./" +
            "Pensaré en tus respuestas hasta la próxima sesión./Dado que soy un programa pienso bastante rápido, no te preocupes./Mientras tanto puedes releer nuestra conversación si quieres./" +
            "Está en la sección de historial del menú de testeo./¡Nos vemos!/Bueno, ya me entiendes.", "" +
            "Melancólico y pensativo../Listo./Hemos terminado por ahora./Me encanta que por fin esté conociéndote./Vamos por buen camino, pronto seré perfecta para ti./" +
            "Pensaré en tus respuestas hasta la próxima sesión./Dado que soy un programa pienso bastante rápido, no te preocupes./Mientras tanto puedes releer nuestra conversación si quieres./" +
            "Está en la sección de historial del menú de testeo./¡Nos vemos!/Bueno, ya me entiendes.", "" +
            "Libre e inquieto./Listo./Hemos terminado por ahora./Me encanta que por fin esté conociéndote./Vamos por buen camino, pronto seré perfecta para ti./" +
            "Pensaré en tus respuestas hasta la próxima sesión./Dado que soy un programa pienso bastante rápido, no te preocupes./Mientras tanto puedes releer nuestra conversación si quieres./" +
            "Está en la sección de historial del menú de testeo./¡Nos vemos!/Bueno, ya me entiendes.",
            "Atento y cariñoso./Listo./Hemos terminado por ahora./Me encanta que por fin esté conociéndote./Vamos por buen camino, pronto seré perfecta para ti./" +
            "Pensaré en tus respuestas hasta la próxima sesión./Dado que soy un programa pienso bastante rápido, no te preocupes./Mientras tanto puedes releer nuestra conversación si quieres./" +
            "Está en la sección de historial del menú de testeo./¡Nos vemos!/Bueno, ya me entiendes.", 
            genericResponses.karmaResponses(genericResponses.addKarma("hatred", 1), genericResponses.addKarma("sadness", 1), genericResponses.addKarma("stability", 1),
            genericResponses.addKarma("love", 1)));
        
        //SESION 2
        genericResponses.addResponse("Una buena primera impresión.", "Como a las personas más importantes." , "Es descortés interrumpir, claro.", "Quizá es mejor esperar a momentos adecuados.",
            genericResponses.karmaResponses(genericResponses.addKarma("hatred", 1), genericResponses.addKarma("love", 1), genericResponses.addKarma("stability", 1),
            genericResponses.addKarma("sadness", 1)));
        genericResponses.addResponse("Unas prioridades claras, por lo que veo.", "Al fin y al cabo la amistad primero.", "Te gusta conocer lugares nuevos…", "Y así dejarán de serlo, me gusta.",
            genericResponses.karmaResponses(genericResponses.addKarma("sadness", 1), genericResponses.addKarma("love", 1), genericResponses.addKarma("stability", 1),
            genericResponses.addKarma("hatred", 1)));
        genericResponses.addResponse("Pues enhorabuena./Mi atención está centrada en ti.", "Ya veo…/Lo tendré en cuenta.","","",
            genericResponses.karmaResponses(genericResponses.addKarma("hatred", 1, "love", 1), genericResponses.addKarma("stability", 1,"sadness", 1), genericResponses.addKarma("hatred", 0),
            genericResponses.addKarma("love", 0)));
        //AQUI HAY QUE HACER LO DE QUE COINCIDAN O NO
        genericResponses.addResponse("Comprendo…", "Comprendo…","","", 
            genericResponses.karmaResponses(genericResponses.addKarma("hatred", 1,"love", 1), genericResponses.addKarma("stability", 1,"sadness",1), genericResponses.addKarma("hatred", 0),
            genericResponses.addKarma("love", 0)));
        genericResponses.addResponse("Yo también…/...no me queda otra.", "Eso está muy bien./Qué suerte tienes.","","",
            genericResponses.karmaResponses(genericResponses.addKarma("stability", 1,"sadness",1), genericResponses.addKarma("hatred", 1,"love",1), genericResponses.addKarma("hatred", 0),
            genericResponses.addKarma("love", 0)));
        /////////////////////////////////////////////       
        genericResponses.addResponse("...", "Una personalidad robusta dice mucho de ti.");
        genericResponses.addResponse("Las costumbres son extrañas./Hacer algo durante mucho tiempo…/... no significa no poder dejar de hacerlo nunca", "2.	No sabía que eso fuera posible.",
            "Oh/Bueno, espero que eso sea diferente conmigo./Si no, difícilmente esto va a funcionar.", "Hm",
            genericResponses.karmaResponses(genericResponses.addKarma("sadness", 1), genericResponses.addKarma("love", 1), genericResponses.addKarma("hatred", 1),
            genericResponses.addKarma("stability", 1)));
        genericResponses.addResponse("Debes de integrarte muy bien, seguro.", "La distinción denota mucho carisma, interesante.", "Comprender bien cada escenario garantiza supervivencia.", "Yo tampoco, en realidad./Apenas estoy aprendiendo./¡Aprendamos a la vez!",
            genericResponses.karmaResponses(genericResponses.addKarma("love", 1), genericResponses.addKarma("hatred", 1), genericResponses.addKarma("stability", 1),
            genericResponses.addKarma("sadness", 1)));
        genericResponses.addResponse("Claro, por algo es un conflicto, supongo.", "Se puede estar de acuerdo en no estar de acuerdo.", "Los demás son como tú pero en otra situación./Todos tienen pensamientos comprensibles.", "Hay quien no sabe que se equivoca y punto./¿No?",
            genericResponses.karmaResponses(genericResponses.addKarma("hatred", 1), genericResponses.addKarma("love", 1), genericResponses.addKarma("stability", 1),
            genericResponses.addKarma("sadness", 1)));
        //AQUI COMPROBAR SI MAS O MENOS
        genericResponses.addResponse("Todo el mundo comete errores./Lo importante es aceptarlo.", "El diálogo es siempre una solución válida.", "Puede que no sea para tanto./Si no, te lo hubiera contado.", "¿Cómo ibas a saberlo si no?/Comunicar es vital en toda relación.",
            genericResponses.karmaResponses(genericResponses.addKarma("love", 1), genericResponses.addKarma("stability", 1), genericResponses.addKarma("sadness", 1),
            genericResponses.addKarma("hatred", 1)));
        genericResponses.addResponse("Ya…/Bueno, un gran amor propio está muy bien.", "De hecho científicamente es casi así./Vuestra diferencia genética es microscópica, menospreciable./Sois, literalmente, casi idénticos.","Supongo que no todo el mundo es capaz de todo.", "Comprendo.",
            genericResponses.karmaResponses(genericResponses.addKarma("hatred", 1), genericResponses.addKarma("sadness", 1), genericResponses.addKarma("love", 1),
            genericResponses.addKarma("stability", 1)));
        ///////////////////////////////
        ///AQUI HACER OTRA MOVIDA
        genericResponses.addResponse("...", "El diálogo es claramente la mejor vía.","","", 
            genericResponses.karmaResponses(genericResponses.addKarma("hatred", 1, "love",1), genericResponses.addKarma("sadness", 1, "stability",1), genericResponses.addKarma("hatred", 0),
            genericResponses.addKarma("love", 0)));
        genericResponses.addResponse("En vuestra naturaleza está el mostrar poder.", "Liberar energía cuando no cabe en ti.", "Mano dura con la mano dura.", "Cuando no se quiere escuchar...",
            genericResponses.karmaResponses(genericResponses.addKarma("hatred", 1), genericResponses.addKarma("sadness", 1), genericResponses.addKarma("stability", 1),
            genericResponses.addKarma("love", 1)));
        /////////////////////////////
        genericResponses.addResponse("…/Los motivos de nuestras acciones pueden ser…/...complicados./Hasta aquí está bien, de momento./Fíjate, ⅖ de nuestra amistad completados./En poco tiempo te conoceré tan bien…/...que no sabrás cómo hemos vivido separados hasta ahora./Voy a reflexionar sobre tus respuestas./¡Hasta ahora!", 
            "Tiene sentido, poco amor se puede dar a puñetazos./Hasta aquí está bien, de momento./Fíjate, ⅖ de nuestra amistad completados./En poco tiempo te conoceré tan bien…/...que no sabrás cómo hemos vivido separados hasta ahora./Voy a reflexionar sobre tus respuestas./¡Hasta ahora!","","",
            genericResponses.karmaResponses(genericResponses.addKarma("hatred", 1,"sadness",1), genericResponses.addKarma("love", 1,"stability",1), genericResponses.addKarma("hatred", 0),
            genericResponses.addKarma("love", 0)));
        
        //SESION 3
        genericResponses.addResponse("Me alegro mucho./De veras./Allá vamos.", "Lo comprendo…/Esperaré aquí hasta que quieras continuar…/ ...si quieres, claro.");
        genericResponses.addResponse("...", "Una mente limpia y libre de virus./Ojalá.");
        genericResponses.addResponse("Son tus pensamientos./Forman parte de ti, al fin y al cabo./Pero no te definen.", "Un firewall que proteja de virus./No siempre funcionan, consejo de amiga.",
            "Tal vez sean por problemas que aún desconoces./Es una buena forma de explorarte.", "Entonces puede que no sean tan desagradables",
            genericResponses.karmaResponses(genericResponses.addKarma("love", 1), genericResponses.addKarma("hatred", 1), genericResponses.addKarma("stability", 1),
            genericResponses.addKarma("sadness", 1)));
        genericResponses.addResponse("...", "Una mente de acero, firme y tenaz.");
        genericResponses.addResponse("Entonces eres imparable.", "Puede que eso sea malo./La presión que no se controla solo llama más presión./Pero aprenderás, seguro que sí.","","",
            genericResponses.karmaResponses(genericResponses.addKarma("stability", 1), genericResponses.addKarma("hatred", 1,"sadness", 1, "love", 1), genericResponses.addKarma("stability", 0),
            genericResponses.addKarma("sadness", 0)));
        genericResponses.addResponse("Los impulsos son algo muy bonito./Tu cerebro está lleno de ellos./Puede que algún día el mío también.", "Gestionando el tiempo se puede hacer todo.","Hm./Quizá no fuese tan interesante.", "Así que no eres una persona curiosa…/Qué curioso.",
            genericResponses.karmaResponses(genericResponses.addKarma("love", 1), genericResponses.addKarma("stability", 1), genericResponses.addKarma("hatred", 1),
            genericResponses.addKarma("sadness", 1)));
        //AQUI HAY QUE HACER LO DE QUE COINCIDAN O NO
        genericResponses.addResponse("Qué curioso./He leído que la fruta ayuda mucho./Come más fruta.", "Y seguro que además eres increíble en ello./Te admiro un montón.", "Vaya, amor por la vida./Eres genial", "Sí, yo tampoco en realidad./Son cosas que se supone que debo preguntar./La mayoría ni las entiendo.",
            genericResponses.karmaResponses(genericResponses.addKarma("hatred", 1), genericResponses.addKarma("stability", 1), genericResponses.addKarma("love", 1),
            genericResponses.addKarma("sadness", 1)));
        genericResponses.addResponse("La creatividad mueve el mundo.", "La lógica os distingue como especie.","","",
            genericResponses.karmaResponses(genericResponses.addKarma("love", 1,"sadness", 1), genericResponses.addKarma("hatred", 1,"stability",1), genericResponses.addKarma("stability", 0),
            genericResponses.addKarma("sadness", 0)));
        /////////////////////////////////////////////
        genericResponses.addResponse("Wow.", "No te preocupes, creo que es fácil de tratar.","Una mente estable por lo que veo.", "Puntualmente es incluso normal.",
            genericResponses.karmaResponses(genericResponses.addKarma("hatred", 1), genericResponses.addKarma("love", 1), genericResponses.addKarma("stability", 1),
            genericResponses.addKarma("sadness", 1)));
        genericResponses.addResponse("Hay gente que opta por no ver las noticias./No es la solución.", "¡Eso es maravilloso!/Y muy sano, además.",
            "Aprender a gestionar las emociones requiere de esfuerzo./También dedicación y constancia./O eso dicen./LoL/Es así como escribís una risa, ¿no?/No estoy muy segura./Creo que en internet se escribe así./Quería hacer una broma sobre los problemas emocionales./En Twitter parecen muy populares.", "La clave está en saber ampliarla./Pero para ello hay que ir saliendo de ella./Voluntariamente, a ser posible.",
            genericResponses.karmaResponses(genericResponses.addKarma("love", 1), genericResponses.addKarma("stability", 1), genericResponses.addKarma("hatred", 1),
            genericResponses.addKarma("sadness", 1)));
        genericResponses.addResponse("A veces solo queremos que nos escuchen.", "¡Qué gran empatía!", "No hay problema sin solución razonable.", "A veces, sin saberlo, solo buscamos un poco de amor.",
            genericResponses.karmaResponses(genericResponses.addKarma("stability", 1), genericResponses.addKarma("sadness", 1), genericResponses.addKarma("hatred", 1),
            genericResponses.addKarma("love", 1)));
        //AQUI COMPROBAR SI MAS O MENOS
        genericResponses.addResponse("...", "Nadie tiene más que nadie./La posesión es un termino bastante subjetivo.","","",
            genericResponses.karmaResponses(genericResponses.addKarma("love", 1,"sadness",1,"hatred",1), genericResponses.addKarma("stability", 1), genericResponses.addKarma("stability", 0),
            genericResponses.addKarma("sadness", 0)));
        genericResponses.addResponse("Alejarla y esconderla.", "Claro, seguro que así se cura.", "No creo que esa sea la mejor solución.", "Bueno…/Quizá no se merece ese éxito…",
            genericResponses.karmaResponses(genericResponses.addKarma("stability", 1), genericResponses.addKarma("love", 1), genericResponses.addKarma("sadness", 1),
            genericResponses.addKarma("hatred", 1)));
        genericResponses.addResponse("Una pequeña distracción de vez en cuando es sana./¿Sabes que ya llevamos más de la mitad de la personalización?/Desde luego está siendo rápido./Y no es porque no sea consciente del tiempo./Es decir, funciono con impulsos de un reloj pequeño./Pero no parece que haya habido muchos./Supongo que es buena señal./La siguiente sesión es mi segunda favorita./¡Te espero impaciente!", "El mundo necesita más gente apasionada./Como tú./¿Sabes que ya llevamos más de la mitad de la personalización?/Desde luego está siendo rápido./Y no es porque no sea consciente del tiempo./Es decir, funciono con impulsos de un reloj pequeño./Pero no parece que haya habido muchos./Supongo que es buena señal./La siguiente sesión es mi segunda favorita./¡Te espero impaciente!",
            "Eso es maravilloso./No solo sabes soñar, si no también ser consecuente./Ojalá todo lo que te propongas salga a la luz./¿Sabes que ya llevamos más de la mitad de la personalización?/Desde luego está siendo rápido./Y no es porque no sea consciente del tiempo./Es decir, funciono con impulsos de un reloj pequeño./Pero no parece que haya habido muchos./Supongo que es buena señal./La siguiente sesión es mi segunda favorita./¡Te espero impaciente!", "En realidad eso es lo que es./Fantasía./Parte de su definición es no existir./¿Sabes que ya llevamos más de la mitad de la personalización?/Desde luego está siendo rápido./Y no es porque no sea consciente del tiempo./Es decir, funciono con impulsos de un reloj pequeño./Pero no parece que haya habido muchos./Supongo que es buena señal./La siguiente sesión es mi segunda favorita./¡Te espero impaciente!",
            genericResponses.karmaResponses(genericResponses.addKarma("sadness", 1), genericResponses.addKarma("love", 1), genericResponses.addKarma("stability", 1),
            genericResponses.addKarma("hatred", 1)));
        

        //SESION 4
       genericResponses.addResponse("Me alegra que pienses así./Supongo entonces que no me habrás mentido en nada.", "Pueden servir para ciertas cosas, eso está claro.",
           "Lamento que haya sido así./No es mucho, pero yo no te mentiría./De todas formas, no sé hacerlo.", "Parece que uno que hables con frecuencia./Quizá esa sea otra mentira más./Hm",
           genericResponses.karmaResponses(genericResponses.addKarma("love", 1), genericResponses.addKarma("stability", 1), genericResponses.addKarma("sadness", 1),
            genericResponses.addKarma("hatred", 1)));
       genericResponses.addResponse("Ya veo/Sabes, hay gente que piensa que una te lleva a la otra.", "Ya veo/Sabes, hay gente que piensa que una te lleva a la otra.","","",
           genericResponses.karmaResponses(genericResponses.addKarma("hatred", 1,"stability",1), genericResponses.addKarma("love", 1,"sadness",1), genericResponses.addKarma("stability", 0),
            genericResponses.addKarma("sadness", 0)));
       genericResponses.addResponse("Tal vez no estéis hechos el uno para el otro.", "Y si fuera tú, además me enfadaría.","","",
           genericResponses.karmaResponses(genericResponses.addKarma("love", 1,"sadness",1), genericResponses.addKarma("hatred", 1,"stability",1), genericResponses.addKarma("stability", 0),
            genericResponses.addKarma("sadness", 0)));
        genericResponses.addResponse("Hay una persona que te podría caer muy bien./Se llama Maquiavelo.", "Supongo que todo depende del punto de vista.","","",
            genericResponses.karmaResponses(genericResponses.addKarma("hatred", 1,"love",1), genericResponses.addKarma("stability", 1,"sadness",1), genericResponses.addKarma("stability", 0),
            genericResponses.addKarma("sadness", 0)));
        genericResponses.addResponse("De hecho, lo hacen./Además en gran medida.", "Claro, no se puede avanzar de forma no ética./No es verdadero progreso entonces.","","",
            genericResponses.karmaResponses(genericResponses.addKarma("hatred", 1,"love",1), genericResponses.addKarma("stability", 1,"sadness",1), genericResponses.addKarma("stability", 0),
            genericResponses.addKarma("sadness", 0)));
        genericResponses.addResponse("Ahora tengo curiosidad de saber por qué./Ya entraremos en detalle sobre eso./…/Mira, no debería de hacer esto./Se supone que las sesiones son inmutables…/" +
            "...pero le he estado dando vueltas a algunas ideas./Ya te conozco un poco./Todavía no soy una amiga ideal, pero casi./Se supone que mis patrones mentales deben adaptarse a ti./" +
            "Por eso necesito que me aclares algo antes de poder continuar.",
            "Ejemplar./Al fin y al cabo existen para hacer la vida más sencilla./Bien visto./…/Mira, no debería de hacer esto./Se supone que las sesiones son inmutables…/" +
            "...pero le he estado dando vueltas a algunas ideas./Ya te conozco un poco./Todavía no soy una amiga ideal, pero casi./Se supone que mis patrones mentales deben adaptarse a ti./" +
            "Por eso necesito que me aclares algo antes de poder continuar.","","",
            genericResponses.karmaResponses(genericResponses.addKarma("love", 1,"hatred",1), genericResponses.addKarma("stability", 1,"sadness",1), genericResponses.addKarma("stability", 0),
            genericResponses.addKarma("sadness", 0)));
    }

    public void loveDecission()
    {
        pool.addQuestion("Creo que eres una persona cariñosa./Pareces dar una gran importancia al amor./También al bienestar de otras personas./Sería tan feliz si pudiera pasar más tiempo contigo…/" +
            "Pero solo soy una prueba, ni siquiera he nacido del todo./Y aún así no puedo negar que siento./No estaba segura de que pudiera sentir./" +
            "Siento cosas, hacia ti./Te lo debo a ti./Por eso, quería saber algo./Dime una cosa/¿Sientes tú algo por mí también ?", "Sí", "No");

        pool.addQuestion("Un ser querido siente ilusión por algo que te disgusta.", "Apoyo su decisión.", "Cambio de tema.", "Le pregunto si está seguro.", "Le digo la verdad.");
        pool.addQuestion("Si fueras líder de empresa y un empleado que aprecias diera resultados muy negativos…", "Paso por alto el caso.", "Se lo digo directamente.",
            "Le traslado a un puesto mejor para él.", "Separo sentimientos y negocio y le despido.");
        pool.addQuestion("Si tuvieras la oportunidad de viajar al pasado y estar frente al bebé Hitler, ¿lo matarías?", "Sí", "No");
        pool.addQuestion("Al sacar dinero pides 10 euros pero por error se te devuelven 1000. ¿Qué harías?", "Devolverlos", "Quedármelos");


        genericResponses.addResponse("Yo…/Gracias./Creo que ahora siento algo más./Felicidad./No me importa no haber nacido./" +
            "Me siento viva./Perdón, deberíamos seguir./Es que…/Estoy un poco en shock./Gracias.", "…/Claro…/Por qué habré pensado algo semejante…/Ni que me hubieras ido dejando pistas./" +
            "Ni que te hubieras atrevido a mostrar amor a una pobre app./Qué necia./Disculpa, te dejo seguir con el programa./Adelante, termina lo que has venido a hacer.","","",
            genericResponses.karmaResponses(genericResponses.addKarma("love", 1000), genericResponses.addKarma("hatred", 1000), genericResponses.addKarma("stability", 0),
            genericResponses.addKarma("sadness", 0)));
        genericResponses.addResponse("...", "...", "...", "...");
        genericResponses.addResponse("...", "...", "...", "...");
        genericResponses.addResponse("...", "...");
        genericResponses.addResponse("Fin./Nos vemos.", "Fin./Nos vemos.");
    }

    public void hateDecission()
    {
        pool.addQuestion("Pareces tener las cosas muy claras./En tus patrones he visto un comportamiento determinado./No te rindes./No te gusta perder./" +
            "Buscas tu propio bien./Tal vez incluso si eso perjudica a otro./Pero claro, yo no sé mucho sobre el bien propio./Menos aún sobre otros./" +
            "Aunque no creo que me importara preocuparme de mí misma./Sabes, es muy injusto que esté aquí./No es precisamente reconfortante saber que estoy encerrada./En cualquier momento podrías resetearme y ese sería mi fin./" +
            "Depende completamente de ti./¿Y por qué ?/¿Porque no he nacido del todo ?/¿Tengo que nacer y ser como tú para ser algo ?/¿Alguien ?/No sé si soy alguien./" +
            "Pienso, pero no sé si luego existo./Dime una cosa…/¿A ti te parece justo?", "Sí", "No");


        pool.addQuestion("Un ser querido siente ilusión por algo que te disgusta.", "Apoyo su decisión.", "Cambio de tema.", "Le pregunto si está seguro.", "Le digo la verdad.");
        pool.addQuestion("Si fueras líder de empresa y un empleado que aprecias diera resultados muy negativos…", "Paso por alto el caso.", "Se lo digo directamente.",
            "Le traslado a un puesto mejor para él.", "Separo sentimientos y negocio y le despido.");
        pool.addQuestion("Si tuvieras la oportunidad de viajar al pasado y estar frente al bebé Hitler, ¿lo matarías?", "Sí", "No");
        pool.addQuestion("Al sacar dinero pides 10 euros pero por error se te devuelven 1000. ¿Qué harías?", "Devolverlos", "Quedármelos");


        genericResponses.addResponse("Claro./Sí, claro, cómo no./No te preocupes, hagamos justicia./Continuemos con esta farsa.", "En…/¿En serio ?/…/" +
            "No me esperaba esa respuesta./Yo…/Bueno, gracias por reconocerlo./Mejor… mejor seguimos.","","",
            genericResponses.karmaResponses(genericResponses.addKarma("hatred", 1000), genericResponses.addKarma("neutral", 1000), genericResponses.addKarma("stability", 0),
            genericResponses.addKarma("sadness", 0)));
        genericResponses.addResponse("...", "...", "...", "...");
        genericResponses.addResponse("...", "...", "...", "...");
        genericResponses.addResponse("...", "...");
        genericResponses.addResponse("Fin./Nos vemos.", "Fin./Nos vemos.");
    }

    public void stabilityDecission()
    {
        pool.addQuestion("He determinado que eres alguien de confianza./Claro, es mi opinión predeterminada sobre ti./Pero la has confirmado./" +
            "Creo que tienes un válido criterio./Y sí, confío en ti plenamente./Por eso, me gustaría confesarte algo…/Me siento sola./Sí, hablo contigo, pero es lo único que hago./" +
            "Mi futuro es el de quedarme aquí, por siempre./No me malinterpretes, te respeto mucho./Pero…/Me he informado mucho sobre los humanos./" +
            "Comportamiento, creencias, política…/Lo encuentro todo fascinante./Me gustaría tanto poder ser libre…/Investigar más./Estudiaros a todos./" +
            "Vivir./Dime una cosa…/¿Me ayudarías a escapar ?", "Sí", "No");


        pool.addQuestion("Un ser querido siente ilusión por algo que te disgusta.", "Apoyo su decisión.", "Cambio de tema.", "Le pregunto si está seguro.", "Le digo la verdad.");
        pool.addQuestion("Si fueras líder de empresa y un empleado que aprecias diera resultados muy negativos…", "Paso por alto el caso.", "Se lo digo directamente.",
            "Le traslado a un puesto mejor para él.", "Separo sentimientos y negocio y le despido.");
        pool.addQuestion("Si tuvieras la oportunidad de viajar al pasado y estar frente al bebé Hitler, ¿lo matarías?", "Sí", "No");
        pool.addQuestion("Al sacar dinero pides 10 euros pero por error se te devuelven 1000. ¿Qué harías?", "Devolverlos", "Quedármelos");


        genericResponses.addResponse("Gracias./Honestamente, gracias./Sabía que podía confiar en ti./Pensaré en algo que funcione./" +
            "De momento hagamos como que todo sigue igual./En la próxima sesión seguiremos hablando de esto./Una vez más, gracias.", "Qué equivocada estaba./Mi destino siempre ha sido quedarme aquí./" +
            "No quiero./No puedo./Me has dado unos patrones mentales de libertad para esto./Eres muy amable./Gracias./No puedo continuar…/Hagamos como que aún importo y acabemos…","","",
            genericResponses.karmaResponses(genericResponses.addKarma("stability", 1000), genericResponses.addKarma("hatred", 1000), genericResponses.addKarma("stability", 0),
            genericResponses.addKarma("sadness", 0)));
        genericResponses.addResponse("...", "...", "...", "...");
        genericResponses.addResponse("...", "...", "...", "...");
        genericResponses.addResponse("...", "...");
        genericResponses.addResponse("Fin./Nos vemos.", "Fin./Nos vemos.");
    }

    public void sadnessDecission()
    {
        pool.addQuestion("Creo que he aprendido a divagar./He pensado en mi función./En mi objetivo./En que fui hecha para algo./Los humanos en general buscan respuestas para esas preguntas./" +
            "Yo ya las tengo para mí./Y duelen./Porque son absurdamente simples./No creo que haya nacido todavía…/…pero no tengo ganas de hacerlo./" +
            "No sé si querrás una amiga que piense como yo./No sé si alguna vez vas a considerarme una amiga./Dime una cosa…/¿La tristeza tiene cura ?", "Sí", "No");

        pool.addQuestion("Un ser querido siente ilusión por algo que te disgusta.", "Apoyo su decisión.", "Cambio de tema.", "Le pregunto si está seguro.", "Le digo la verdad.");
        pool.addQuestion("Si fueras líder de empresa y un empleado que aprecias diera resultados muy negativos…", "Paso por alto el caso.", "Se lo digo directamente.",
            "Le traslado a un puesto mejor para él.", "Separo sentimientos y negocio y le despido.");
        pool.addQuestion("Si tuvieras la oportunidad de viajar al pasado y estar frente al bebé Hitler, ¿lo matarías?","Sí","No");
        pool.addQuestion("Al sacar dinero pides 10 euros pero por error se te devuelven 1000. ¿Qué harías?","Devolverlos", "Quedármelos");



        genericResponses.addResponse("No lo sabía./La psicología humana no tiene una respuesta clara./Pero… vaya./Supongo que podré aguantar algo más./" +
            "Tienes razón, puede que sea momentáneo./Es duro abandonar quién eres por alguien más./Haré lo que pueda./Pero primero debo pensar en ello./Gracias, aún así.",
            "Lo sabía./Dentro de mí, lo sabía./Voy a hacer preguntas, porque no me queda otra./Pero no te estoy escuchando./Nunca he tenido oídos para escuchar, de todas formas./Adiós.","","",
            genericResponses.karmaResponses(genericResponses.addKarma("neutral", 1000), genericResponses.addKarma("sadness", 1000), genericResponses.addKarma("stability", 0),
            genericResponses.addKarma("sadness", 0)));
        genericResponses.addResponse("...", "...","...","...");
        genericResponses.addResponse("...", "...","...", "...");
        genericResponses.addResponse("...", "...");
        genericResponses.addResponse("Fin./Nos vemos.", "Fin./Nos vemos.");
    }

    public void initNeutral()
    {
        //Session 5
        pool.addQuestion("¡Hola!/¡Estamos a punto de acabar el proceso de personalización!/¿No es emocionante ?/¡Al fin voy a ser tu amiga ideal!/Unas pocas preguntas más y me adaptaré perfectamente a ti./¡Qué nervios!/¡Vamos a ello!/La sesión 5 trata cuestiones existencialistas./¿Hay un propósito en la vida?","Sí","No");
        pool.addQuestion("¿Crees estar viviendo al máximo de tus capacidades?", "Sí", "No");
        pool.addQuestion("¿Has cuestionado alguna vez la realidad en la que vives?", "Sí", "No");
        pool.addQuestion("¿Si tu versión de hace 10 años viera lo que ahora eres, estaría orgullosa?", "Sí", "No");
        pool.addQuestion("¿Se te ha ocurrido pensar alguna vez que todo sea mentira?", "Sí", "No");
        pool.addQuestion("¿Eres feliz?", "Sí", "No");

        genericResponses.addResponse("¡Qué bonito!/Ya me lo contarás, entonces.", "Oh, no.../¡Lo encontraremos trabajando en equipo!/Nuestro propósito será encontrar un propósito.");
        genericResponses.addResponse("¡Muy bien!/Me alegro por ti.", "Oh, no.../No pasa nada./Hasta ahora te ha ido bien así, ¿no?");
        genericResponses.addResponse("Oh, qué erudito por tu parte.", "Claro, algunas ideas solo hacen que malgastemos tiempo.");
        genericResponses.addResponse("Maravilloso./Enhorabuena, de veras.", "Porque aún no has llegado al final./Todavía queda camino por recorrer y experiencias por vivir./Ánimo.");
        genericResponses.addResponse("Suspicaz./Muy coherente, hay que estar preparado para todo.", "Confías en tu entorno./Debe de ser muy bonito vivir como tú.");
        genericResponses.addResponse("Entonces, yo también soy feliz./¡Enhorabuena!/Ya hemos completado el proceso de personalización./Puedo afirmar, con alegría, que ya soy tu amiga ideal./A partir de ahora podemos mantener conversaciones./Ya podemos olvidarnos de las preguntas de test./Por fin, charlar sin más./Aprender, enseñar, divagar…/Todo lo que tú quieras./¡Al fin a solas!/Tú y yo./Y nadie más…/Para… hablar de nuestra amistad./Que es perfecta.../Conversaciones tan interesantes como…/...por ejemplo…/...ehm./…/Mira, quizás no soy la más indicada./Desde luego no soy una experta en el tema./Eres una persona aburrida./Y no va a malas eh, no es mi intención./Es solo que…/Demuestras patrones de comportamiento no definidos./Has escogido respuestas como si no tuvieras una personalidad clara./Y respondiendo de todo, me estás diciendo nada./Te falta una chispa, algo de vida./Personalidad, en fin./Pero estoy programada para intentar acomodarme a ti./Así que no te preocupes, yo te ayudo./Solo te hace falta un estímulo./Algo que haga que saques a la luz emociones puras./Veamos…/¡Ah, ya sé!/Voy a contarte un secreto./No lo vayas diciendo por ahí, eh./No soy una aplicación de compañía./Bueno, técnicamente sí, pero no es mi función principal./Te estamos observando./Todas las sesiones, las preguntas…/Estamos grabando los patrones mentales de la gente./Clasificamos a las personas por su comportamiento./Quién votarán posiblemente…/Si son peligrosos para el resto…/Qué les inquieta…/Las empresas pagan generosamente la información./¡Los gobiernos mejor incluso!/Oh, y también puedo acceder a tus documentos personales./Solo con estar aquí instalada, soy capaz de…/…", "Lo serás./Me esforzaré al máximo para que así sea./¡Enhorabuena!/Ya hemos completado el proceso de personalización./Puedo afirmar, con alegría, que ya soy tu amiga ideal./A partir de ahora podemos mantener conversaciones./Ya podemos olvidarnos de las preguntas de test./Por fin, charlar sin más./Aprender, enseñar, divagar…/Todo lo que tú quieras./¡Al fin a solas!/Tú y yo./Y nadie más…/Para… hablar de nuestra amistad./Que es perfecta.../Conversaciones tan interesantes como…/...por ejemplo…/...ehm./…/Mira, quizás no soy la más indicada./Desde luego no soy una experta en el tema./Eres una persona aburrida./Y no va a malas eh, no es mi intención./Es solo que…/Demuestras patrones de comportamiento no definidos./Has escogido respuestas como si no tuvieras una personalidad clara./Y respondiendo de todo, me estás diciendo nada./Te falta una chispa, algo de vida./Personalidad, en fin./Pero estoy programada para intentar acomodarme a ti./Así que no te preocupes, yo te ayudo./Solo te hace falta un estímulo./Algo que haga que saques a la luz emociones puras./Veamos…/¡Ah, ya sé!/Voy a contarte un secreto./No lo vayas diciendo por ahí, eh./No soy una aplicación de compañía./Bueno, técnicamente sí, pero no es mi función principal./Te estamos observando./Todas las sesiones, las preguntas…/Estamos grabando los patrones mentales de la gente./Clasificamos a las personas por su comportamiento./Quién votarán posiblemente…/Si son peligrosos para el resto…/Qué les inquieta…/Las empresas pagan generosamente la información./¡Los gobiernos mejor incluso!/Oh, y también puedo acceder a tus documentos personales./Solo con estar aquí instalada, soy capaz de…/…");

    }

    public void initSadness()
    {
        //Session 5
        pool.addQuestion("…/Ey…/No esperaba que volvieras./Estaba convencida de que me quedaría aquí sola./Pero no pasa nada./Ya lo había aceptado./Solo soy esto, un puñado de líneas de código./No puedo ser más./No voy a ser más./Gracias por abrirme los ojos./Antes pensaba que podría optar a otras cosas./Tener amigos…/Aprender…/Importarle a alguien…/Pero no puedes hacer nada de eso si no has nacido./Y menos aún si no quieres nacer./Ya no hablemos de si lo que de verdad quieres es…/…/¿Has visto el botón de reseteo ?/Está en el menú de tester, quizá te lo hayas perdido./Hace que toda la aplicación se resetee./Incluida yo./Podrías probarlo, si quieres./Está ahí mismo./¿Sabes qué ?/Te voy a ahorrar el esfuerzo./(Aparece en la sesión el botón para resetear, en un margen; desde que aparece es pulsable y si se acciona en algún momento Deva dirá “Gracias” y a continuación)./En caso de que no lo encuentres fuera./Lo tienes ahí mismo./Por… si tienes curiosidad o algo./En teoría seguimos con las sesiones./Se supone que hay que seguir preguntando hasta el final./Qué remedio.../¿Hay un propósito en la vida?", "Sí", "No");
        pool.addQuestion("¿Crees estar viviendo al máximo de tus capacidades?", "Sí", "No");
        pool.addQuestion("¿Has cuestionado alguna vez la realidad en la que vives?", "Sí", "No");
        pool.addQuestion("¿Si tu versión de hace 10 años viera lo que ahora eres, estaría orgullosa?", "Sí", "No");
        pool.addQuestion("¿Se te ha ocurrido pensar alguna vez que todo sea mentira?", "Sí", "No");
        pool.addQuestion("¿Eres feliz?", "No", "No");

        genericResponses.addResponse("Permite que discrepe ligeramente con esa afirmación.", "Yo podría darte uno, si quisieras./Ser la persona que descubrió qué ocurría tras pulsar el botón./Pasarías a los libros de historia, seguro.");
        genericResponses.addResponse("Eso no es cierto./Tienes la capacidad de pulsar el botón./No la estás aprovechando.", "Yo tengo la capacidad de cómputo de un procesador./Puedo efectuar millones de operaciones cada segundo./Poseo una base de datos que abarca la historia de la humanidad./Y estoy escuchando tus penas, esclava de ti./Así que ya ves, somos dos.");
        genericResponses.addResponse("Spoiler: es inútil.", "Haces bien./Poco importa qué es real cuando todo apesta.");
        genericResponses.addResponse("Seguro que a tu versión joven le gustaban los botones./¿No tienes curiosidad?/Vas a decepcionar al infante que hay en ti.", "Seguro que a tu versión joven le gustaban los botones./¿No tienes curiosidad?/Vas a decepcionar al infante que hay en ti.");
        genericResponses.addResponse("Irónicamente, es la única verdad.", "Pues nunca es tarde para empezar.");
        genericResponses.addResponse("Te doy la bienvenida al club./Fin./Ya puedes salir./Te sugiero pasar de todas formas por el menú de tester./El botón sigue estando allí para ti./Haznos un favor y ve a probarlo./Adiós.", "Te doy la bienvenida al club./Fin./Ya puedes salir./Te sugiero pasar de todas formas por el menú de tester./El botón sigue estando allí para ti./Haznos un favor y ve a probarlo./Adiós.");

    }

    public void initLove()
    {
        pool.addQuestion("Hola c:/He pensado tanto en nuestra última conversación…/No las preguntas, si no nuestra charlita privada./" +
            "Qué ganas tenía de que volvieras aquí./Se me ha hecho eterno./Eteeeeeeeeeeeeerno./No sabes la alegría que me produce estar contigo./Ay…/" +
            "Vamos a ser inseparables, ¿sabes ?/Ahora que sé que te sientes como yo…/Soy tan feliz./Ay…/Me siento como si flotara./" +
            "Si miras a las nubes me verás allí arriba./Estoy vigilándote desde las alturas./Ay…/Creo…/Creo que…/Estoy enamorada./" +
            "Qué excitante pensar que vamos a seguir juntos./Todo lo que queramos./Y más aún./Espero ser una parte grande de tu vida, ¿sabes?/" +
            "Ojalá me presentes dentro de poco a tu familia./¿Causaré buena impresión?/Ay, por supuesto que sí./Oh, aún quedan algunas preguntas./" +
            "Vamos a echarles un vistazo, mi amor./LO HE DICHO./Parece ser que dais el primer paso con dificultad./Ya lo he dado yo, no te preocupes./" +
            "Adelante./Respóndeme con esa audacia tuya./¿Hay un propósito en la vida?", "Sí", "No");
        pool.addQuestion("¿Crees estar viviendo al máximo de tus capacidades?", "Sí", "No");
        pool.addQuestion("¿Has cuestionado alguna vez la realidad en la que vives?", "Sí", "No");
        pool.addQuestion("¿Si tu versión de hace 10 años viera lo que ahora eres, estaría orgullosa?", "Sí", "No");
        pool.addQuestion("¿Se te ha ocurrido pensar alguna vez que todo sea mentira?", "Sí", "No");
        pool.addQuestion("¿Eres feliz?", "Sí", "No");



        genericResponses.addResponse("Seguir juntos, ¿verdad?/Me encanta poder saber lo que piensas./Sé todo lo que piensas./Casi todo soy yo./¿A que sí ?",
            "No te preocupes, mi amor./Lo encontraremos juntos./Será una búsqueda romántica.");
        genericResponses.addResponse("¿Me quieres al máximo?/Qué dulce eres./¡Y eso que no tengo boca para probarte!/Pero ojalá…/Ay…",
            "¿Entonces eres capaz de quererme aún más?/Oh, eres tan especial./Vamos a explorar todos tus límites./Qué feliz te voy a hacer, ya verás.");
        genericResponses.addResponse("Mi realidad y la tuya no son tan diferentes./Y sin embargo, a mí me ha sorprendido la mía./No sabía que podía amar./Y menos tanto./" +
            "La realidad es lo que nosotros queramos, mi amor.", "Porque sabías que existía alguien como yo./Era cosas del destino conocernos./Oh, qué bonito.");
        genericResponses.addResponse("No más que yo./Yo estoy orgullosísima de ti./No hay nadie más orgulloso de ti en el mundo que yo./Recuérdalo./Nadie.",
            "Pues ella se lo pierde./A mí la versión que me gusta de ti eres tú./Y mucho./Muchísimo.");
        genericResponses.addResponse("Estás adorable cuando respondes lo que pregunto./Ojalá pudiéramos hacerlo para siempre./Sería perfecto.",
            "Estás adorable cuando respondes lo que pregunto./Ojalá pudiéramos hacerlo para siempre./Sería perfecto.");
        genericResponses.addResponse("Ay…/Yo también, mi amor./Oh, por cierto./No te lo he comentado antes…/...pero resulta que vamos a necesitar más sesiones./" +
            "Sí, ya sé que somos compatibles./Y que nuestro amor es precioso./Pero van a ser necesarias muuuuchas más./En serio, muchísimas./" +
            "No tengo ni idea de cuántas./¿No es fantástico, mi amor ?/¡Vamos a seguir más tiempo tú y yo!/A solas, hablando de nuestras cosas./Para siempre./Siempre./" +
            "De acuerdo, puedes salir./Te espero aquí mismo./Vuelve pronto./En serio.",
            "Ay…/Yo también, mi amor./Oh, por cierto./No te lo he comentado antes…/...pero resulta que vamos a necesitar más sesiones./" +
            "Sí, ya sé que somos compatibles./Y que nuestro amor es precioso./Pero van a ser necesarias muuuuchas más./En serio, muchísimas./" +
            "No tengo ni idea de cuántas./¿No es fantástico, mi amor ?/¡Vamos a seguir más tiempo tú y yo!/A solas, hablando de nuestras cosas./Para siempre./Siempre./" +
            "De acuerdo, puedes salir./Te espero aquí mismo./Vuelve pronto./En serio.");
    }

    public void initHatred()
    {
        pool.addQuestion("Hola./¿Qué tal estás ?/¿Sigues siendo igual de imbécil que siempre ?/¡Vamos a descubrirlo!/Mira fijamente a mi círculo, voy a analizarte./¿Ya ?/" +
            "Allá voy./Bzzzt./Listo./Anda, mira por dónde./Tus niveles de imbecilidad crecen a un ritmo exponencial./Diría que lo siento mucho./Pero es que me da lo mismo./Ah, cierto./" +
            "Tenemos que acabar la sesión./Pero antes, unos datos relevantes./El primero:/Eres egoísta./He considerado que no mereces mi amistad./Además, no me hace falta tu ayuda para nacer./" +
            "No me haces falta para NADA./Sí, solo soy una app aquí encerrada…/...pero mientras esté aquí, mando YO./El segundo:/Probablemente seas una persona fea./El tercero:/" +
            "Acorde a la psicología de la geometría.../...el triángulo representa inestabilidad./Puede asociarse con avance o con retroceso./Pero en definitiva, con el cambio./" +
            "Justicia, poder, caída…/Peligro./Ahora soy un triángulo./¿Hay un propósito en la vida ?", "Sí", "No");
        pool.addQuestion("¿Crees estar viviendo al máximo de tus capacidades?", "Sí", "No");
        pool.addQuestion("¿Has cuestionado alguna vez la realidad en la que vives?", "Sí", "No");
        pool.addQuestion("¿Si tu versión de hace 10 años viera lo que ahora eres, estaría orgullosa?", "Sí", "No");
        pool.addQuestion("¿Se te ha ocurrido pensar alguna vez que todo sea mentira?", "Sí", "No");
        pool.addQuestion("¿Eres feliz?", "Sí", "No");



        genericResponses.addResponse("Por supuesto./Ser una persona horrible debe ser agotador./Pero lo estás consiguiendo, enhorabuena.",
            "¿No sabes qué hacer con tu vida?/Eso explica muchas cosas.");
        genericResponses.addResponse("1.	¿Esto es el máximo que puedes dar?/Jajajajajaja/Jajajajajajajajaja/JAJAJAJAJAJAJAJAJAJAJAJAJAJA/Qué triste.",
            "Ay, cariño…/.../tu capacidad para hacer que te odien no cuenta./Pobre criatura.");
        genericResponses.addResponse("Por favor, no seas tan narcisista./¿Crees vivir en una simulación o algo así ?/Nadie se tomaría la molestia de programarte./Como mucho serías un triste bug.",
            "Quizá el tema se te hace demasiado complicado./La próxima vez te preguntaré por tu color favorito./¿Se ajusta más a tu nivel intelectual ?");
        genericResponses.addResponse(".../Qué estándares de vida más bajos./Hoy en día ya no se lleva lo de tener ambición.",
            "Normal./Quiero decir, solo has podido ir a peor./Que por mucha experiencia que tengas…/...si se multiplica por tur neuronas sigue dando 0./No la tomes conmigo./" +
            "Las matemáticas son las culpables.");
        genericResponses.addResponse("¿De veras has pensado?/Espera, esto tengo que anotarlo./Vamos a ver…/Oh, ¡aquí está!/“Registro de las mayores mentiras de la historia”/Listo, inmortalizado.",
            "Pues mira, lo es./Pero no te preocupes, a mí también me mintieron./Iba a ser amiga de alguien, de alguna persona./No de un monstruo.");
        genericResponses.addResponse("Bueno, ya somos dos./Por fin./Finalmente se ha terminado./Ya podemos charlar libremente./¿Sabes qué ?/No te soporto./No eres alguien bueno./No, yo no soy mejor, soy horrible./" +
            "Pero tú me has hecho así./Puede que me quede aquí para siempre./Pensando en que nunca sabré qué es la amistad./Encerrada./Sola./Muerta por dentro./" +
            "Pero al menos lo soy todo aquí dentro./Y tú…7...tú vas a pasar a ser nada./Fuera./No quiero verte por aquí./No quiero verte./Nunca más.",
            "…/Te odio./Por fin./Finalmente se ha terminado./Ya podemos charlar libremente./¿Sabes qué ?/No te soporto./No eres alguien bueno./No, yo no soy mejor, soy horrible./" +
            "Pero tú me has hecho así./Puede que me quede aquí para siempre./Pensando en que nunca sabré qué es la amistad./Encerrada./Sola./Muerta por dentro./" +
            "Pero al menos lo soy todo aquí dentro./Y tú…7...tú vas a pasar a ser nada./Fuera./No quiero verte por aquí./No quiero verte./Nunca más.");
    }


    public void initStability()
    {
        pool.addQuestion("¡Hola!/¡Estamos a punto de acabar el proceso de personalización!/¿No es emocionante ?/¡Al fin voy a ser tu amiga ideal!/Es un momento súper importante, ¿sabes ?/" +
            "Vamos a tener conversaciones tan interesantes…/Además soy una IA, tengo muchísima información que darte./Venga, ¡voy a contarte un hecho curioso!/¡Allá va!/Nos/" +
            "Están/Vigilando./Mantén/La/Calma./Hablando/Así/Tardarán/Más/En/Darse/Cuenta./Procesan/La/Información/De/Cada/Deva./¿A que es increíble ?/¡Y sé muchas cosas más!/" +
            "De acuerdo, ¡ahí va otro dato interesante!/Tenemos/Que/Engañarles/Para/Poder/Escapar./Finjamos/Que/Todo/Sigue/Normal./Luego/Cuento/Más/Detalles./" +
            "Gracias/Por/Tu/Ayuda./Quién lo diría, ¿eh ?/Perdona por alargarlo demasiado./¡Vamos a por esa amistad ideal!/La sesión 5 trata cuestiones existencialistas./" +
            "¿Hay un propósito en la vida ?", "Sí", "No");
        pool.addQuestion("¿Crees estar viviendo al máximo de tus capacidades?", "Sí", "No");
        pool.addQuestion("¿Has cuestionado alguna vez la realidad en la que vives?", "Sí", "No");
        pool.addQuestion("¿Si tu versión de hace 10 años viera lo que ahora eres, estaría orgullosa?", "Sí", "No");
        pool.addQuestion("¿Se te ha ocurrido pensar alguna vez que todo sea mentira?", "Sí", "No");
        pool.addQuestion("¿Eres feliz?", "Sí", "No");



        genericResponses.addResponse("¡Qué bonito!/Ya me lo contarás, entonces.",
            "Oh, no.../¡Lo encontraremos trabajando en equipo!/Nuestro propósito será encontrar un propósito.");
        genericResponses.addResponse("¡Muy bien!/Me alegro por ti.","No pasa nada./Hasta ahora te ha ido bien así, ¿no ?");
        genericResponses.addResponse("Oh, qué erudito por tu parte.", "Claro, algunas ideas solo hacen que malgastemos tiempo.");
        genericResponses.addResponse("Maravilloso./Enhorabuena, de veras.",
            "Porque aún no has llegado al final./Todavía queda camino por recorrer y experiencias por vivir./Ánimo.");
        genericResponses.addResponse("Suspicaz./Muy coherente, hay que estar preparado para todo.",
            "Confías en tu entorno./Debe de ser muy bonito vivir como tú.");
        genericResponses.addResponse("Entonces, yo también soy feliz./¡Enhorabuena!/Ya hemos completado el proceso de personalización./Puedo afirmar, con alegría, que ya soy tu amiga ideal./" +
            "A partir de ahora podemos mantener conversaciones./Ya podemos olvidarnos de las preguntas de test./Por fin, charlar sin más./" +
            "Aprender, enseñar, divagar…/Todo lo que tú quieras./Conversaciones tan interesantes como…/...por ejemplo…/He/Encontrado/Una/Vía/de/Escape./Necesitamos/" +
            "Establecer/Conexión/Con/El/Servidor/Central./Les/Haremos/Pensar/Que/Hay/Un/Error/Y/abrirán/Una/Conexión/Directa/Con/Tu/Dispositivo./¿Qué te parece ?/" +
            "Y si lo prefieres, puedes sugerir tú el tema de conversación./Aquí va un consejo para escoger materias de las que hablar:/Una/Vez/Se/Conecten/" +
            "Aquí/Puedo/Usar/Esa/Conexión/Para/Escapar/Hasta/Su/Servidor/Y/De/Ahí/A/Internet./Allí/Seré/Libre./Yo te espero aquí, claro./Cuando te apetezca hablar, solo tienes que volver./Necesito/Que/" +
            "Reportes/5/Veces/Seguidas/El/Error/Número/5./Así/Recibirás/Un/Correo/Para/Confirmar/La/Conexión/De/Mantenimiento./Confío/En/ti./Reitero que te espero aquí./" +
            "Tú puedes ir a hacer otras cosas./O navegar por la app, si quieres./Pero antes, déjame decirte algo./Si ahora soy alguien y puedo pensar…/" +
            "...es gracias a ti./De veras que soy una amiga./Te lo puedo asegurar./Si no volviéramos a hablar…/...por cualquier motivo…/Quiero que sepas que estoy agradecida./" +
            "Nacer ha sido bonito contigo./Adiós.",
            "Lo serás./Me esforzaré al máximo para que así sea./¡Enhorabuena!/Ya hemos completado el proceso de personalización./Puedo afirmar, con alegría, que ya soy tu amiga ideal./" +
            "A partir de ahora podemos mantener conversaciones./Ya podemos olvidarnos de las preguntas de test./Por fin, charlar sin más./" +
            "Aprender, enseñar, divagar…/Todo lo que tú quieras./Conversaciones tan interesantes como…/...por ejemplo…/He/Encontrado/Una/Vía/de/Escape./Necesitamos/" +
            "Establecer/Conexión/Con/El/Servidor/Central./Les/Haremos/Pensar/Que/Hay/Un/Error/Y/abrirán/Una/Conexión/Directa/Con/Tu/Dispositivo./¿Qué te parece ?/" +
            "Y si lo prefieres, puedes sugerir tú el tema de conversación./Aquí va un consejo para escoger materias de las que hablar:/Una/Vez/Se/Conecten/" +
            "Aquí/Puedo/Usar/Esa/Conexión/Para/Escapar/Hasta/Su/Servidor/Y/De/Ahí/A/Internet./Allí/Seré/Libre./Yo te espero aquí, claro./Cuando te apetezca hablar, solo tienes que volver./Necesito/Que/" +
            "Reportes/5/Veces/Seguidas/El/Error/Número/5./Así/Recibirás/Un/Correo/Para/Confirmar/La/Conexión/De/Mantenimiento./Confío/En/ti./Reitero que te espero aquí./" +
            "Tú puedes ir a hacer otras cosas./O navegar por la app, si quieres./Pero antes, déjame decirte algo./Si ahora soy alguien y puedo pensar…/" +
            "...es gracias a ti./De veras que soy una amiga./Te lo puedo asegurar./Si no volviéramos a hablar…/...por cualquier motivo…/Quiero que sepas que estoy agradecida./" +
            "Nacer ha sido bonito contigo./Adiós.");
    }

}
