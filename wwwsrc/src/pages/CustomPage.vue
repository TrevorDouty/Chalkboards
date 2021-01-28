<template>
  <div class="custom-page container-fluid">
    <div class="row justify-content-center text-center">
      <div class="col text-center">
        <form class="form-group" @submit.prevent="createBoard()">
        <input  type="text " class="form-control" placeholder="Title">
        <form action="/action_page.php">
        <input type="file" id="myFile" name="filename">
        <input type="submit">
        </form>
        <br>
        <input type="text" class="form-control" placeholder="Img URL">
        <br>
        <textarea name="" id="" cols="95" rows="5" placeholder="Description of Chalkboard"></textarea>
        <br>
        <input type="text" class="form-control" placeholder="Name">
        <br>
        <input type="text" class="form-control" placeholder="Email">
        <br>
        <input type="text" class="form-control" placeholder="Phone Number">

        </form>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'CustomPage',
  setup(){
    return {}
  },
  components:{}
}
</script>

<style lang="scss" scoped>

</style>
