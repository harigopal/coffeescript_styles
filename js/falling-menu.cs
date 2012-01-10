$ ->
  $("a").hover(
    (->
      option_number = $(this).attr("id")[2..3]
      space_id = "div#in#{option_number}"
      $(space_id).animate { "height": "100px" }
    ), (->
      option_number = $(this).attr("id")[2..3]
      space_id = "div#in#{option_number}"
      $(space_id).animate { "height": "0px" }
    ))
