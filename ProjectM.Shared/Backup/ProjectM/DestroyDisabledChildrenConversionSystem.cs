// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroyDisabledChildrenConversionSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class DestroyDisabledChildrenConversionSystem : GameObjectConversionSystem
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724053, XrefRangeEnd = 724082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyDisabledChildrenConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DestroyDisabledChildrenConversionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyDisabledChildrenConversionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyDisabledChildrenConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyDisabledChildrenConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DestroyDisabledChildrenConversionSystem()
    {
      Il2CppClassPointerStore<DestroyDisabledChildrenConversionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DestroyDisabledChildrenConversionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyDisabledChildrenConversionSystem>.NativeClassPtr);
      DestroyDisabledChildrenConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyDisabledChildrenConversionSystem>.NativeClassPtr, 100664040);
      DestroyDisabledChildrenConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyDisabledChildrenConversionSystem>.NativeClassPtr, 100664041);
      DestroyDisabledChildrenConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyDisabledChildrenConversionSystem>.NativeClassPtr, 100664042);
    }

    public DestroyDisabledChildrenConversionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("ProjectM.DestroyDisabledChildrenConversionSystem/<>c__DisplayClass0_0")]
    public sealed class __c__DisplayClass0_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_transformsToDestroy;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Transform_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyDisabledChildrenConversionSystem.__c__DisplayClass0_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyDisabledChildrenConversionSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724033, XrefRangeEnd = 724053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Transform transform)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyDisabledChildrenConversionSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<DestroyDisabledChildrenConversionSystem.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyDisabledChildrenConversionSystem>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyDisabledChildrenConversionSystem.__c__DisplayClass0_0>.NativeClassPtr);
        DestroyDisabledChildrenConversionSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_transformsToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyDisabledChildrenConversionSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (transformsToDestroy));
        DestroyDisabledChildrenConversionSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyDisabledChildrenConversionSystem.__c__DisplayClass0_0>.NativeClassPtr, 100664043);
        DestroyDisabledChildrenConversionSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyDisabledChildrenConversionSystem.__c__DisplayClass0_0>.NativeClassPtr, 100664044);
      }

      public __c__DisplayClass0_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe List<Transform> transformsToDestroy
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyDisabledChildrenConversionSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_transformsToDestroy));
          return pointer == System.IntPtr.Zero ? (List<Transform>) null : new List<Transform>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DestroyDisabledChildrenConversionSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_transformsToDestroy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
