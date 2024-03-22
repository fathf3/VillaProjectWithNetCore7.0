function deleteDeal(button) {
    var Id = button.getAttribute("id");
    var controllerName = button.getAttribute("controllerName");
    console.log(controllerName);
        Swal.fire({
            title: "Silmek istediğinize Emin misiniz ?",
            text: "Bu işlemi geri alamassınız!!",
            icon: "warning",
            showCancelButton: true,
            confirmButtonColor: "#3085d6",
            cancelButtonColor: "#d33",
            confirmButtonText: "Evet sil",
            cancelButtonText: "İptal"
        }).then((result) => {
            if (result.isConfirmed) {

                window.location.href = "/Admin/" + controllerName +"/Delete/" + Id;
            }
        });
    };