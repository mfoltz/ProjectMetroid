// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkedComponentConversionSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  public class NetworkedComponentConversionSystem : GameObjectConversionSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__DisableIgnoreListServerMask;
    private static readonly System.IntPtr NativeFieldInfoPtr__DisableIgnoreListClientMask;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableIgnoreListServer_Private_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableIgnoreListClient_Private_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785169, XrefRangeEnd = 785213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), NetworkedComponentConversionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785213, XrefRangeEnd = 785234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), NetworkedComponentConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785235, RefRangeEnd = 785236, XrefRangeStart = 785234, XrefRangeEnd = 785235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool DisableIgnoreListServer(Entity networkedComponentConversionEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &networkedComponentConversionEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkedComponentConversionSystem.NativeMethodInfoPtr_DisableIgnoreListServer_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785237, RefRangeEnd = 785238, XrefRangeStart = 785236, XrefRangeEnd = 785237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool DisableIgnoreListClient(Entity networkedComponentConversionEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &networkedComponentConversionEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkedComponentConversionSystem.NativeMethodInfoPtr_DisableIgnoreListClient_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkedComponentConversionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkedComponentConversionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkedComponentConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), NetworkedComponentConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NetworkedComponentConversionSystem()
    {
      Il2CppClassPointerStore<NetworkedComponentConversionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (NetworkedComponentConversionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedComponentConversionSystem>.NativeClassPtr);
      NetworkedComponentConversionSystem.NativeFieldInfoPtr__DisableIgnoreListServerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedComponentConversionSystem>.NativeClassPtr, nameof (_DisableIgnoreListServerMask));
      NetworkedComponentConversionSystem.NativeFieldInfoPtr__DisableIgnoreListClientMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedComponentConversionSystem>.NativeClassPtr, nameof (_DisableIgnoreListClientMask));
      NetworkedComponentConversionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedComponentConversionSystem>.NativeClassPtr, 100669166);
      NetworkedComponentConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedComponentConversionSystem>.NativeClassPtr, 100669167);
      NetworkedComponentConversionSystem.NativeMethodInfoPtr_DisableIgnoreListServer_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedComponentConversionSystem>.NativeClassPtr, 100669168);
      NetworkedComponentConversionSystem.NativeMethodInfoPtr_DisableIgnoreListClient_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedComponentConversionSystem>.NativeClassPtr, 100669169);
      NetworkedComponentConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedComponentConversionSystem>.NativeClassPtr, 100669170);
      NetworkedComponentConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedComponentConversionSystem>.NativeClassPtr, 100669171);
    }

    public NetworkedComponentConversionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQueryMask _DisableIgnoreListServerMask
    {
      get
      {
        return *(EntityQueryMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponentConversionSystem.NativeFieldInfoPtr__DisableIgnoreListServerMask));
      }
      [param: In] set
      {
        *(EntityQueryMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponentConversionSystem.NativeFieldInfoPtr__DisableIgnoreListServerMask)) = value;
      }
    }

    public unsafe EntityQueryMask _DisableIgnoreListClientMask
    {
      get
      {
        return *(EntityQueryMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponentConversionSystem.NativeFieldInfoPtr__DisableIgnoreListClientMask));
      }
      [param: In] set
      {
        *(EntityQueryMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponentConversionSystem.NativeFieldInfoPtr__DisableIgnoreListClientMask)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Network.NetworkedComponentConversionSystem/<>c__DisplayClass3_0")]
    public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_componentsToAdd;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_NetworkedComponent_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass3_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkedComponentConversionSystem.__c__DisplayClass3_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetworkedComponentConversionSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784985, XrefRangeEnd = 785169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity conversionEntity, NetworkedComponent component)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &conversionEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) component);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetworkedComponentConversionSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_NetworkedComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass3_0()
      {
        Il2CppClassPointerStore<NetworkedComponentConversionSystem.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkedComponentConversionSystem>.NativeClassPtr, "<>c__DisplayClass3_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedComponentConversionSystem.__c__DisplayClass3_0>.NativeClassPtr);
        NetworkedComponentConversionSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_componentsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedComponentConversionSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (componentsToAdd));
        NetworkedComponentConversionSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedComponentConversionSystem.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
        NetworkedComponentConversionSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedComponentConversionSystem.__c__DisplayClass3_0>.NativeClassPtr, 100669172);
        NetworkedComponentConversionSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_NetworkedComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedComponentConversionSystem.__c__DisplayClass3_0>.NativeClassPtr, 100669173);
      }

      public __c__DisplayClass3_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe List<ComponentType> componentsToAdd
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponentConversionSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_componentsToAdd));
          return pointer == System.IntPtr.Zero ? (List<ComponentType>) null : new List<ComponentType>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponentConversionSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_componentsToAdd), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NetworkedComponentConversionSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponentConversionSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (NetworkedComponentConversionSystem) null : new NetworkedComponentConversionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponentConversionSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
