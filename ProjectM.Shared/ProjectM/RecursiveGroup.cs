// Decompiled with JetBrains decompiler
// Type: ProjectM.RecursiveGroup
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class RecursiveGroup : ComponentSystemGroup
  {
    private static readonly IntPtr NativeFieldInfoPtr__QuerySpawned;
    private static readonly IntPtr NativeFieldInfoPtr__QueryDestroyed;
    private static readonly IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly IntPtr NativeFieldInfoPtr__DestroyBarrier;
    private static readonly IntPtr NativeFieldInfoPtr__DestroyGroup;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761705, XrefRangeEnd = 761768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RecursiveGroup.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761768, XrefRangeEnd = 761784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RecursiveGroup.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761784, XrefRangeEnd = 761788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RecursiveGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecursiveGroup>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RecursiveGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RecursiveGroup.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RecursiveGroup()
    {
      Il2CppClassPointerStore<RecursiveGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RecursiveGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecursiveGroup>.NativeClassPtr);
      RecursiveGroup.NativeFieldInfoPtr__QuerySpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecursiveGroup>.NativeClassPtr, nameof (_QuerySpawned));
      RecursiveGroup.NativeFieldInfoPtr__QueryDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecursiveGroup>.NativeClassPtr, nameof (_QueryDestroyed));
      RecursiveGroup.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecursiveGroup>.NativeClassPtr, nameof (_SpawnBarrier));
      RecursiveGroup.NativeFieldInfoPtr__DestroyBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecursiveGroup>.NativeClassPtr, nameof (_DestroyBarrier));
      RecursiveGroup.NativeFieldInfoPtr__DestroyGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecursiveGroup>.NativeClassPtr, nameof (_DestroyGroup));
      RecursiveGroup.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecursiveGroup>.NativeClassPtr, 100667255);
      RecursiveGroup.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecursiveGroup>.NativeClassPtr, 100667256);
      RecursiveGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecursiveGroup>.NativeClassPtr, 100667257);
      RecursiveGroup.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecursiveGroup>.NativeClassPtr, 100667258);
    }

    public RecursiveGroup(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _QuerySpawned
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecursiveGroup.NativeFieldInfoPtr__QuerySpawned));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecursiveGroup.NativeFieldInfoPtr__QuerySpawned)) = value;
      }
    }

    public unsafe EntityQuery _QueryDestroyed
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecursiveGroup.NativeFieldInfoPtr__QueryDestroyed));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecursiveGroup.NativeFieldInfoPtr__QueryDestroyed)) = value;
      }
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecursiveGroup.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecursiveGroup.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DestroyBarrier _DestroyBarrier
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecursiveGroup.NativeFieldInfoPtr__DestroyBarrier));
        return pointer == IntPtr.Zero ? (DestroyBarrier) null : new DestroyBarrier(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecursiveGroup.NativeFieldInfoPtr__DestroyBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DestroyGroup _DestroyGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecursiveGroup.NativeFieldInfoPtr__DestroyGroup));
        return pointer == IntPtr.Zero ? (DestroyGroup) null : new DestroyGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecursiveGroup.NativeFieldInfoPtr__DestroyGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
