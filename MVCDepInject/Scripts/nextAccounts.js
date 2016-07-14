$(document).ready(function () {
	var accountsCount = 2;
	var index = 0;
	$('#nextButton').click(function () {
		$.ajax({
			url: "/Home/NextAccounts",
			data: { 'startIndex': index, 'accountsCount': accountsCount },
			type: "get",
			success: function (data) {
				$(data).appendTo("#accountsList");
				index += accountsCount;
			}
		});
	});
})