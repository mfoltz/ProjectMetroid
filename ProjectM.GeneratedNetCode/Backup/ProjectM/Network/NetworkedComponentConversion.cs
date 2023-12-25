// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkedComponentConversion
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  public static class NetworkedComponentConversion : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TryAttachSnapshotComponents;
    private static readonly System.IntPtr NativeMethodInfoPtr_AttachSnapshot_Private_Static_Void_Entity_NetworkSnapshotType_EntityManager_EntityCommandBuffer_Boolean_byref_Boolean_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1512723, RefRangeEnd = 1512724, XrefRangeStart = 1504095, XrefRangeEnd = 1512723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AttachSnapshot(
      Entity entity,
      NetworkSnapshotType snapshotType,
      EntityManager entityManager,
      EntityCommandBuffer entityCommandBuffer,
      bool isServerWorld,
      ref bool added)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isServerWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref added;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkedComponentConversion.NativeMethodInfoPtr_AttachSnapshot_Private_Static_Void_Entity_NetworkSnapshotType_EntityManager_EntityCommandBuffer_Boolean_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NetworkedComponentConversion()
    {
      Il2CppClassPointerStore<NetworkedComponentConversion>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (NetworkedComponentConversion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedComponentConversion>.NativeClassPtr);
      NetworkedComponentConversion.NativeFieldInfoPtr_TryAttachSnapshotComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedComponentConversion>.NativeClassPtr, nameof (TryAttachSnapshotComponents));
      NetworkedComponentConversion.NativeMethodInfoPtr_AttachSnapshot_Private_Static_Void_Entity_NetworkSnapshotType_EntityManager_EntityCommandBuffer_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedComponentConversion>.NativeClassPtr, 100664091);
    }

    public NetworkedComponentConversion(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate TryAttachSnapshotComponents
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(NetworkedComponentConversion.NativeFieldInfoPtr_TryAttachSnapshotComponents, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate) null : new NetworkSnapshotUtils.TryAttachSnapshotComponentsDelegate(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkedComponentConversion.NativeFieldInfoPtr_TryAttachSnapshotComponents, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.Network.NetworkedComponentConversion/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__2_0_Internal_Boolean_Entity_NetworkSnapshotType_EntityManager_EntityCommandBuffer_Boolean_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkedComponentConversion.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetworkedComponentConversion.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1504091, XrefRangeEnd = 1504095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool __cctor_b__2_0(
        Entity entity,
        NetworkSnapshotType snapshotType,
        EntityManager entityManager,
        EntityCommandBuffer entityCommandBuffer,
        bool isServerWorld)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityCommandBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isServerWorld;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkedComponentConversion.__c.NativeMethodInfoPtr___cctor_b__2_0_Internal_Boolean_Entity_NetworkSnapshotType_EntityManager_EntityCommandBuffer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<NetworkedComponentConversion.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkedComponentConversion>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedComponentConversion.__c>.NativeClassPtr);
        NetworkedComponentConversion.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedComponentConversion.__c>.NativeClassPtr, "<>9");
        NetworkedComponentConversion.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedComponentConversion.__c>.NativeClassPtr, 100664094);
        NetworkedComponentConversion.__c.NativeMethodInfoPtr___cctor_b__2_0_Internal_Boolean_Entity_NetworkSnapshotType_EntityManager_EntityCommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedComponentConversion.__c>.NativeClassPtr, 100664095);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe NetworkedComponentConversion.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(NetworkedComponentConversion.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (NetworkedComponentConversion.__c) null : new NetworkedComponentConversion.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(NetworkedComponentConversion.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
