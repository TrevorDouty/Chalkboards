<template>

  <div class="home flex-grow-1 d-flex flex-column align-items-center justify-content-center bg-dark row">
<div class="border border-white rounded">

    <h1 class="my-5 bg-dark text-light p-3 rounded  text-center">
      <div class="mx-2 text-white classy">Brie's Boards</div>
    </h1>
      <p class="text-light nice">Creating beautiful designs to meet your event needs.</p>
</div>
  </div>
</template>

<script>
export default {
  name: 'Home'
}
</script>

<style scoped lang="scss">
.home{
  text-align: center;
  user-select: none;
  > img{
    height: 200px;
    width: 200px;
  }
}

.classy{
  font-family: 'Italianno', cursive;
  font-size: 175%;
}

.nice{
  font-family: 'Italianno', cursive;
}
</style>
