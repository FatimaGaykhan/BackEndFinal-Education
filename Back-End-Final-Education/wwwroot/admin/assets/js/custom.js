
//delete product in edit
$(document).on("click", ".image-card-product .delete-btn", function () {
	let imageId = parseInt($(this).attr("data-id"));
	let courseId = parseInt($(this).attr("data-courseId"));

	let data = { courseId, imageId };

	$.ajax({
		type: "POST",
		url: `/admin/course/deletecourseimage`,
		data: data,
		success: function (response) {
			$(`[data-id=${imageId}]`).closest(".image-card-product").remove();
		},
		error: function (jqXHR, textStatus, errorThrown) {
			console.error('Error:', textStatus, errorThrown);
		}
	});
});


$(document).on("click", ".image-card-product .main-image-btn", function () {
	let imageId = parseInt($(this).attr("data-id"));

	let courseId = parseInt($(this).attr("data-courseId"));

	let data = { courseId, imageId };

	$.ajax({
		type: "POST",
		url: `/admin/course/setmainimage?`,
		data: data,
		success: function (response) {

			$(".is-main-image").removeClass("is-main-image");
			$(`[data-id=${imageId}]`).closest(".image-card-product").find("img").addClass("is-main-image");
			$(".hide-btn").addClass("show-btn").removeClass("hide-btn");

			$(`[data-id=${imageId}]`).closest(".image-card-product").addClass("hide-btn").removeClass("show-btn");

			
		}
	});


})


$(document).on("click", "#instructorEdit .btn-danger", function () {
	let instructorId = parseInt($(this).attr("data-instructorId"));
	let socialMediaId = parseInt($(this).attr("data-socialId"));
	let link = $(this).attr("data-link");

	console.log(instructorId)

	let li=$(this).closest("li")
	let data = { instructorId, socialMediaId, link };
	$.ajax({
		type: "POST",
		url: `/admin/instructor/deletesocialmedialink`,
		data: data,
		success: function () {
			li.remove()
		}
	})
})




////scialmedialinks
//let socialMediaLinksWrappers = document.querySelectorAll(".socialMediaLinksWrapper")
//let socialmedialinks = document.querySelectorAll(".socialMediaLinks")

//socialmedialinks.forEach(linkElement => {
//	let splittedLinkArray = linkElement.innerText.split(",");
//	//console.log(splittedLinkArray)

//	splittedLinkArray.forEach(oneLink => {
//		//console.log(oneLink)

//		socialMediaLinksWrappers.forEach(wrapper => {
//			wrapper.innerHTML += `
//				<a style="display:block;" href="${oneLink}">${oneLink}</a>
//			`
//		})
//		//wrapper.innerHTML += `
//		// <a style="display:block;" href="${oneLink}">${oneLink}</a>
//		//`
//	})

//}

//)


//console.log(socialmedialinks)

//let allLinks = socialmedialinks.innerText.split(",")

//allLinks.forEach(link => socialMediaLinksWrapper.innerHTML += `
//      <a style="display:block;" href="${link}">${link}</a>
//`)

//console.log(allLinks)

