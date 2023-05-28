﻿$(document).ready(function() {
    $(document).on("click", ".book-modal-open", function (e) {
        e.preventDefault()

        var url= $(this).attr("href")

        fetch(url)
            .then((response) => response.text())
            .then(modalHtml => {
                $("#quickModal .modal-dialog").html(modalHtml)
            })
                    
      
            $("#quickModal").modal("show")

    })


})