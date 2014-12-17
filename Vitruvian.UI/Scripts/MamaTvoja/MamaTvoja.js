$(document).on('click', '#mamaTvojaBtn', function () {
	$.post("MamaTvoja/GetClient", { clientId : 1 }, function(response) {
		console.log(response);
	});
});