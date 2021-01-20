<template>
  <div class="browse-page">
<browse-component v-for="board in boards" :key="board.id" :props: board-prop/>
  </div>
</template>


<script>
export default {
  name: 'BrowsePage',
  setup(){
    return {}
  },
  components:{}
}
</script>


<style lang="scss" scoped>

</style>
