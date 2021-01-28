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
<img src="../assets/img/Baby1.png" alt="" class="img-fluid pt-2 rounded-circle">
</div>
      <div class="col-3 text-center">
        <h3>Holidays</h3>
        <img src="../assets/img/holiday.png" alt="" class="img-fluid pt-5 round border border-light">
      </div>
      <div class="col-3 text-center">
        <h3>Inspirational</h3>
        <img src="../assets/img/inspire2.png" alt="" class="img-fluid rounder">
      </div>
    </div>
    <div class="row">
      <div class="col text-center">
        <p>All Boards Are Custom Made</p>
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
.underline {
  text-decoration: underline;
}
.round {
  border-radius: 15%;
  border-color: white;
}
.rounder {
  border-radius: 60%;
}
</style>
