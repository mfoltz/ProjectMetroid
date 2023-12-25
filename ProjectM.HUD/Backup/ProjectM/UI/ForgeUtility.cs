// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ForgeUtility
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public static class ForgeUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SendInsertItemEvent_Internal_Static_Void_EntityManager_NetworkId_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendInsertItemEvent_Internal_Static_Void_EntityManager_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendRemoveItemEvent_Internal_Static_Void_EntityManager_NetworkId_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendRemoveItemEvent_Internal_Static_Void_EntityManager_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendRemoveItemEvent_Internal_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetMotion_Internal_Static_Void_GameObject_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236393, XrefRangeEnd = 1236396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendInsertItemEvent(
      EntityManager entityManager,
      NetworkId fromInventory,
      int inventoryIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromInventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForgeUtility.NativeMethodInfoPtr_SendInsertItemEvent_Internal_Static_Void_EntityManager_NetworkId_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236396, XrefRangeEnd = 1236402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendInsertItemEvent(
      EntityManager entityManager,
      Entity fromInventory,
      int inventoryIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromInventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForgeUtility.NativeMethodInfoPtr_SendInsertItemEvent_Internal_Static_Void_EntityManager_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1236405, RefRangeEnd = 1236406, XrefRangeStart = 1236402, XrefRangeEnd = 1236405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendRemoveItemEvent(
      EntityManager entityManager,
      NetworkId toInventory,
      int inventoryIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForgeUtility.NativeMethodInfoPtr_SendRemoveItemEvent_Internal_Static_Void_EntityManager_NetworkId_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236406, XrefRangeEnd = 1236412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendRemoveItemEvent(
      EntityManager entityManager,
      Entity toInventory,
      int inventoryIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inventoryIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForgeUtility.NativeMethodInfoPtr_SendRemoveItemEvent_Internal_Static_Void_EntityManager_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236412, XrefRangeEnd = 1236418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SendRemoveItemEvent(EntityManager entityManager, Entity toInventory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &toInventory;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForgeUtility.NativeMethodInfoPtr_SendRemoveItemEvent_Internal_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236418, XrefRangeEnd = 1236420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ResetMotion(GameObject gameObject)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForgeUtility.NativeMethodInfoPtr_ResetMotion_Internal_Static_Void_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ForgeUtility()
    {
      Il2CppClassPointerStore<ForgeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ForgeUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeUtility>.NativeClassPtr);
      ForgeUtility.NativeMethodInfoPtr_SendInsertItemEvent_Internal_Static_Void_EntityManager_NetworkId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeUtility>.NativeClassPtr, 100665803);
      ForgeUtility.NativeMethodInfoPtr_SendInsertItemEvent_Internal_Static_Void_EntityManager_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeUtility>.NativeClassPtr, 100665804);
      ForgeUtility.NativeMethodInfoPtr_SendRemoveItemEvent_Internal_Static_Void_EntityManager_NetworkId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeUtility>.NativeClassPtr, 100665805);
      ForgeUtility.NativeMethodInfoPtr_SendRemoveItemEvent_Internal_Static_Void_EntityManager_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeUtility>.NativeClassPtr, 100665806);
      ForgeUtility.NativeMethodInfoPtr_SendRemoveItemEvent_Internal_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeUtility>.NativeClassPtr, 100665807);
      ForgeUtility.NativeMethodInfoPtr_ResetMotion_Internal_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeUtility>.NativeClassPtr, 100665808);
    }

    public ForgeUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
