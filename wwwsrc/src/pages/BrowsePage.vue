<template>
  <div class="browse-page container-fluid bg-dark text-light underline">
    <div class="row pb-2">
      <div class="col text-center">
        <h1>Browse Chalkboards</h1>
      </div>
    </div>
    <div class="row justify-content-around">
      <div class="col-3 text-center">
        <h3>
          Events
        </h3>
<img src="../assets/img/Baby1.png" alt="" class="img-fluid pt-2">
</div>
      <div class="col-3 text-center">
        <h3>Holidays</h3>
        <img src="../assets/img/holiday.png" alt="" class="img-fluid pt-5">
      </div>
      <div class="col-3 text-center">
        <h3>Inspirational</h3>
        <img src="../assets/img/inspire.png" alt="" class="img-fluid">
      </div>
    </div>
    <div class="row">
      <div class="col text-center">
        <p>Click On Categories To View More Examples</p>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'BrowsePage',
  setup() {
    return {}
  },
  components: {}
}
</script>


<style lang="scss" scoped>
.underline{
  text-decoration: underline;
}
</style>
