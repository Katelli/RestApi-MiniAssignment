# Mine refleksjoner om hvordan RestAPIer fungerer

En RestAPI er en API som følger et sett med regler og konvensjoner/retningslinjer som lar froskjellige applikasjoner kommunisere med hverandre over internettet. REST(Representational state transfer) er en arikitekturstil som separerer implementasjonen av klient og server siden, noe som gjør at de fungerer uavhengig av hverandre, og endringer i en av sidene vil ikke påvirke den andre. Dette gir bedre ytelse og fleksibiltet, så lenge hver side vet i hvilken format de skal sende meldinger/forespørsler til hverandre, vanligvis i form av Http metoder.

## Hvorfor modeller kan være nyttig å anvende.

Modeller er nyttig for å definiere strukturen for dataene som sendes og mottas mellom serveren og klienten, sikre at dataen sendes i riktig format fra klienten, sette og sende standardiserte feilmeldinger og forhindre feil og avvik. Modeller gjør også koden mer oversiktlig så det er enklere å gjøre endringer i feltene, og for å lage dokumentasjon for APIen. Du kan også bruke samme modell til flere ting (f. eks. lage, oppdatere og hente et objekt).
