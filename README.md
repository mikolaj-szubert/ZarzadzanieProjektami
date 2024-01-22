# SystemZarzadzaniaProjektami
System posiada konto administratora które pozwala na dostęp do zarządzania użytkownikami i pozwala na nadanie uprawnień. Dla bezpieczeństwa po zmodyfikowaniu nowo założonego konta do roli Administratora (karta localhost:port/Users), należy usunąć komentarz w pliku Controllers/UsersController.cs w linijce, żeby kod wyglądał tak: [Authorize(Roles = "Admin")]
Moderator oraz Admin może edytować i usuwać projekty, a każdy zalogowany użytkownik może dodawać i edytować zadania w projekcie.
Ponadto każdy użytkownik, nawet niezalogowany, ma wgląd w projekty.