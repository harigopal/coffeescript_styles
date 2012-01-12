$ ->
  $("a.arim").hover(
    (->
      # Squeeze the upper overlay out.
      option_number = $(this).attr("id")[4..5]
      space_id = "div#riin#{option_number}"
      $(space_id).animate { "height": "0px" }

      # Remove the inverted kitten background image from option.
      option_id = "a#riop#{option_number}"
      $(option_id).css('background-image', 'none')
      $(option_id).css('color', "black")
    ), (->
      # Bring back the upper space overlay.
      option_number = $(this).attr("id")[4..5]
      space_id = "div#riin#{option_number}"
      $(space_id).animate { "height": "100px" }

      # Reset kitten inverted image on option
      option_id = "a#riop#{option_number}"
      $(option_id).css('background-image', 'url("images/kitten_inverted.jpg")')
      $(option_id).css('color', "white")
    ))

# Set the inverted background images for both options and upper spaces on page load.
$ ->
  for id in [1..5]
    do (id) ->
      space_id  = "div#riin#{id}"
      option_id = "a#riop#{id}"
      $(option_id).css('background-image', 'url("images/kitten_inverted.jpg")')
      $(space_id).css('background-image', 'url("images/kitten_inverted.jpg")')
      horizontal_position = -142 * (Number(id) - 1)
      $(option_id).css('background-position', "#{horizontal_position}px 99%")
      $(space_id).css('background-position', "#{horizontal_position}px 0%")