// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroyGroup
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class DestroyGroup : ComponentSystemGroup
  {
    private static readonly IntPtr NativeFieldInfoPtr__DestroyedThisUpdate;
    private static readonly IntPtr NativeFieldInfoPtr__DestroyedThisFrame;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_EnableDestroyedThisFrame_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761788, XrefRangeEnd = 761799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyGroup.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761799, XrefRangeEnd = 761803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyGroup.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761803, XrefRangeEnd = 761887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyGroup.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 761900, RefRangeEnd = 761901, XrefRangeStart = 761887, XrefRangeEnd = 761900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EnableDestroyedThisFrame()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyGroup.NativeMethodInfoPtr_EnableDestroyedThisFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761901, XrefRangeEnd = 761905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DestroyGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyGroup>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyGroup.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DestroyGroup()
    {
      Il2CppClassPointerStore<DestroyGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DestroyGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyGroup>.NativeClassPtr);
      DestroyGroup.NativeFieldInfoPtr__DestroyedThisUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyGroup>.NativeClassPtr, nameof (_DestroyedThisUpdate));
      DestroyGroup.NativeFieldInfoPtr__DestroyedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyGroup>.NativeClassPtr, nameof (_DestroyedThisFrame));
      DestroyGroup.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyGroup>.NativeClassPtr, 100667259);
      DestroyGroup.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyGroup>.NativeClassPtr, 100667260);
      DestroyGroup.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyGroup>.NativeClassPtr, 100667261);
      DestroyGroup.NativeMethodInfoPtr_EnableDestroyedThisFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyGroup>.NativeClassPtr, 100667262);
      DestroyGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyGroup>.NativeClassPtr, 100667263);
      DestroyGroup.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyGroup>.NativeClassPtr, 100667264);
    }

    public DestroyGroup(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _DestroyedThisUpdate
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyGroup.NativeFieldInfoPtr__DestroyedThisUpdate));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyGroup.NativeFieldInfoPtr__DestroyedThisUpdate)) = value;
      }
    }

    public unsafe NativeList<Entity> _DestroyedThisFrame
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyGroup.NativeFieldInfoPtr__DestroyedThisFrame));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyGroup.NativeFieldInfoPtr__DestroyedThisFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
