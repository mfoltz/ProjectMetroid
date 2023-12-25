// Decompiled with JetBrains decompiler
// Type: ProjectM.WorkstationUtils
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class WorkstationUtils : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_CRAFT_QUEUE_SIZE;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindQueuedCraftAction_Public_Static_Boolean_DynamicBuffer_1_QueuedWorkstationCraftAction_PrefabGUID_byref_QueuedWorkstationCraftAction_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeAmount_Public_Static_Int32_DynamicBuffer_1_QueuedWorkstationCraftAction_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindLastIndex_Public_Static_Boolean_DynamicBuffer_1_QueuedWorkstationCraftAction_PrefabGUID_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetQueueSpot_Public_Static_Int32_DynamicBuffer_1_QueuedWorkstationCraftAction_Int32_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1043102, RefRangeEnd = 1043105, XrefRangeStart = 1043093, XrefRangeEnd = 1043102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindQueuedCraftAction(
      DynamicBuffer<QueuedWorkstationCraftAction> actions,
      PrefabGUID recipeGuid,
      out QueuedWorkstationCraftAction craftAction,
      out int craftIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &actions;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref craftAction;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref craftIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorkstationUtils.NativeMethodInfoPtr_TryFindQueuedCraftAction_Public_Static_Boolean_DynamicBuffer_1_QueuedWorkstationCraftAction_PrefabGUID_byref_QueuedWorkstationCraftAction_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1043114, RefRangeEnd = 1043117, XrefRangeStart = 1043105, XrefRangeEnd = 1043114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetTypeAmount(
      DynamicBuffer<QueuedWorkstationCraftAction> actions,
      PrefabGUID recipeGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &actions;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorkstationUtils.NativeMethodInfoPtr_GetTypeAmount_Public_Static_Int32_DynamicBuffer_1_QueuedWorkstationCraftAction_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1043124, RefRangeEnd = 1043125, XrefRangeStart = 1043117, XrefRangeEnd = 1043124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindLastIndex(
      DynamicBuffer<QueuedWorkstationCraftAction> actions,
      PrefabGUID recipeGuid,
      out int lastIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &actions;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref lastIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorkstationUtils.NativeMethodInfoPtr_TryFindLastIndex_Public_Static_Boolean_DynamicBuffer_1_QueuedWorkstationCraftAction_PrefabGUID_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1043134, RefRangeEnd = 1043137, XrefRangeStart = 1043125, XrefRangeEnd = 1043134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetQueueSpot(
      DynamicBuffer<QueuedWorkstationCraftAction> actions,
      int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &actions;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorkstationUtils.NativeMethodInfoPtr_GetQueueSpot_Public_Static_Int32_DynamicBuffer_1_QueuedWorkstationCraftAction_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static WorkstationUtils()
    {
      Il2CppClassPointerStore<WorkstationUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WorkstationUtils));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkstationUtils>.NativeClassPtr);
      WorkstationUtils.NativeFieldInfoPtr_MAX_CRAFT_QUEUE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationUtils>.NativeClassPtr, nameof (MAX_CRAFT_QUEUE_SIZE));
      WorkstationUtils.NativeMethodInfoPtr_TryFindQueuedCraftAction_Public_Static_Boolean_DynamicBuffer_1_QueuedWorkstationCraftAction_PrefabGUID_byref_QueuedWorkstationCraftAction_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationUtils>.NativeClassPtr, 100681745);
      WorkstationUtils.NativeMethodInfoPtr_GetTypeAmount_Public_Static_Int32_DynamicBuffer_1_QueuedWorkstationCraftAction_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationUtils>.NativeClassPtr, 100681746);
      WorkstationUtils.NativeMethodInfoPtr_TryFindLastIndex_Public_Static_Boolean_DynamicBuffer_1_QueuedWorkstationCraftAction_PrefabGUID_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationUtils>.NativeClassPtr, 100681747);
      WorkstationUtils.NativeMethodInfoPtr_GetQueueSpot_Public_Static_Int32_DynamicBuffer_1_QueuedWorkstationCraftAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationUtils>.NativeClassPtr, 100681748);
    }

    public WorkstationUtils(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int MAX_CRAFT_QUEUE_SIZE
    {
      get
      {
        int maxCraftQueueSize;
        IL2CPP.il2cpp_field_static_get_value(WorkstationUtils.NativeFieldInfoPtr_MAX_CRAFT_QUEUE_SIZE, (void*) &maxCraftQueueSize);
        return maxCraftQueueSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(WorkstationUtils.NativeFieldInfoPtr_MAX_CRAFT_QUEUE_SIZE, (void*) &value);
      }
    }
  }
}
