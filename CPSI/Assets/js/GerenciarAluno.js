//Mask jquery
$(document).ready(function () {
    var $TextBoxCalendarDataNascimento = $(".data-nascimento");
    $TextBoxCalendarDataNascimento.mask('00/00/0000', { reverse: true });
});
$(document).ready(function () {
    var $TextBoxCpf = $(".CPF");
    $TextBoxCpf.mask('000.000.000-00', { reverse: true });
});
//Validação jquery validator
