var webpage = require('webpage');
var page = webpage.create();
var fs = require('fs');

page.onConsoleMessage = function(msg) {
	console.log(msg);  
};

var m = 1;

var today = new Date();
var dd = today.getDate();
var mm = today.getMonth()+1; //January is 0!
var yyyy = today.getFullYear();
if(dd<10) { dd='0'+dd }
if(mm<10) { mm='0'+mm } 
today = yyyy+'-'+mm+'-'+dd+' ';

page.onCallback = function(result) {
	fs.write(today + m + '.txt', JSON.stringify(result), 'w');
	m = m + 1;
}

page.open('https://www.zapimoveis.com.br/aluguel/apartamentos/rs+porto-alegre/#{"possuiendereco":"True","parametrosautosuggest":[{"Bairro":"","Zona":"","Cidade":"PORTO ALEGRE","Agrupamento":"","Estado":"RS"}],"pagina":"1","paginaOrigem":"Home","formato":"Lista"}', function(status) {
  console.log("Status: " + status);
  if(status === "success") {
	  page.evaluate(function() {
		  function recAjax(i) {
			  $.ajax({
				type: "POST",
				async: !0,
				url: "/Busca/RetornarBuscaAssincrona/",
				data: {
					tipoOferta: 1,
					paginaAtual: i,
					// ordenacaoSelecionada: u.ordem,
					pathName: "/aluguel/apartamentos/rs+porto-alegre/",
					hashFragment: '{"possuiendereco":"True","parametrosautosuggest":[{"Bairro":"","Zona":"","Cidade":"PORTO ALEGRE","Agrupamento":"","Estado":"RS"}],"pagina":' + i + ',"paginaOrigem":"Home","formato":"Lista"}',
					formato: "Lista"
				},
				success: function(n) {
					console.log(n.Resultado.PaginaAtual);
					window.callPhantom(n);
					
					if (i + 1 <= $('input#quantidadeTotalPaginas').attr('data-value'))
						recAjax(i + 1);
				},
				error: function() {
					
				},
				complete: function() {
					
				}
			})
		  }
		  
		 recAjax(1);
	  });
  }
});
