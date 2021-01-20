<template>

  <div class="home flex-grow-1 d-flex flex-column align-items-center justify-content-center bg-dark row">
<img src="../assets/img/HomeLogo.png" alt="" class=" h-75 w-25">
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
}

.nice{
  font-family: 'Italianno', cursive;
  font-size: 120%;
}

.floral{
  background-image: url("../assets/img/HomeLogo.png") ;
  background-repeat: no-repeat;
  background-size: 100%;
}

.logo{
  height: 150%;
  width: auto;
}

</style>
