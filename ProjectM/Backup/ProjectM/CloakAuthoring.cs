// Decompiled with JetBrains decompiler
// Type: ProjectM.CloakAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class CloakAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_TopPartSkinnedMeshRenderer;
    private static readonly IntPtr NativeFieldInfoPtr_BottomPartMaterial;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CloakAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloakAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CloakAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CloakAuthoring()
    {
      Il2CppClassPointerStore<CloakAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CloakAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloakAuthoring>.NativeClassPtr);
      CloakAuthoring.NativeFieldInfoPtr_TopPartSkinnedMeshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloakAuthoring>.NativeClassPtr, nameof (TopPartSkinnedMeshRenderer));
      CloakAuthoring.NativeFieldInfoPtr_BottomPartMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloakAuthoring>.NativeClassPtr, nameof (BottomPartMaterial));
      CloakAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloakAuthoring>.NativeClassPtr, 100676140);
    }

    public CloakAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SkinnedMeshRenderer TopPartSkinnedMeshRenderer
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloakAuthoring.NativeFieldInfoPtr_TopPartSkinnedMeshRenderer));
        return pointer == IntPtr.Zero ? (SkinnedMeshRenderer) null : new SkinnedMeshRenderer(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CloakAuthoring.NativeFieldInfoPtr_TopPartSkinnedMeshRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material BottomPartMaterial
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloakAuthoring.NativeFieldInfoPtr_BottomPartMaterial));
        return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CloakAuthoring.NativeFieldInfoPtr_BottomPartMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
