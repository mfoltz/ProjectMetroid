// Decompiled with JetBrains decompiler
// Type: ProjectM.ClientEventValidation
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
  public static class ClientEventValidation : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_INTERACT_DISTANCE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_INTERACT_DISTANCE_SQ;
    private static readonly System.IntPtr NativeMethodInfoPtr_CouldReasonablyInteractWith_Public_Static_Boolean_Entity_Entity_byref_EntityManager_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInteractingWithInventory_Public_Static_Boolean_Entity_Entity_byref_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInteractingWithWorkstation_Public_Static_Boolean_Entity_Entity_byref_EntityManager_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 987032, RefRangeEnd = 987036, XrefRangeStart = 987025, XrefRangeEnd = 987032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CouldReasonablyInteractWith(
      Entity interactor,
      Entity interacted,
      [In] ref EntityManager entityManager,
      bool allowHostileInteraction = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &interactor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &interacted;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &allowHostileInteraction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientEventValidation.NativeMethodInfoPtr_CouldReasonablyInteractWith_Public_Static_Boolean_Entity_Entity_byref_EntityManager_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(38)]
    [CachedScanResults(RefRangeStart = 987092, RefRangeEnd = 987130, XrefRangeStart = 987036, XrefRangeEnd = 987092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInteractingWithInventory(
      Entity interactor,
      Entity inventory,
      [In] ref EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &interactor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityManager;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientEventValidation.NativeMethodInfoPtr_IsInteractingWithInventory_Public_Static_Boolean_Entity_Entity_byref_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 987137, RefRangeEnd = 987140, XrefRangeStart = 987130, XrefRangeEnd = 987137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInteractingWithWorkstation(
      Entity interactor,
      Entity workstation,
      [In] ref EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &interactor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &workstation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityManager;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientEventValidation.NativeMethodInfoPtr_IsInteractingWithWorkstation_Public_Static_Boolean_Entity_Entity_byref_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ClientEventValidation()
    {
      Il2CppClassPointerStore<ClientEventValidation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ClientEventValidation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientEventValidation>.NativeClassPtr);
      ClientEventValidation.NativeFieldInfoPtr_MAX_INTERACT_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventValidation>.NativeClassPtr, nameof (MAX_INTERACT_DISTANCE));
      ClientEventValidation.NativeFieldInfoPtr_MAX_INTERACT_DISTANCE_SQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventValidation>.NativeClassPtr, nameof (MAX_INTERACT_DISTANCE_SQ));
      ClientEventValidation.NativeMethodInfoPtr_CouldReasonablyInteractWith_Public_Static_Boolean_Entity_Entity_byref_EntityManager_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventValidation>.NativeClassPtr, 100676137);
      ClientEventValidation.NativeMethodInfoPtr_IsInteractingWithInventory_Public_Static_Boolean_Entity_Entity_byref_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventValidation>.NativeClassPtr, 100676138);
      ClientEventValidation.NativeMethodInfoPtr_IsInteractingWithWorkstation_Public_Static_Boolean_Entity_Entity_byref_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventValidation>.NativeClassPtr, 100676139);
    }

    public ClientEventValidation(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe float MAX_INTERACT_DISTANCE
    {
      get
      {
        float interactDistance;
        IL2CPP.il2cpp_field_static_get_value(ClientEventValidation.NativeFieldInfoPtr_MAX_INTERACT_DISTANCE, (void*) &interactDistance);
        return interactDistance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClientEventValidation.NativeFieldInfoPtr_MAX_INTERACT_DISTANCE, (void*) &value);
      }
    }

    public static unsafe float MAX_INTERACT_DISTANCE_SQ
    {
      get
      {
        float interactDistanceSq;
        IL2CPP.il2cpp_field_static_get_value(ClientEventValidation.NativeFieldInfoPtr_MAX_INTERACT_DISTANCE_SQ, (void*) &interactDistanceSq);
        return interactDistanceSq;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClientEventValidation.NativeFieldInfoPtr_MAX_INTERACT_DISTANCE_SQ, (void*) &value);
      }
    }
  }
}
