// Decompiled with JetBrains decompiler
// Type: ProjectM.HybridEquipmentSkinnedMesh
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using MagicaCloth;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class HybridEquipmentSkinnedMesh : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_magicaMeshCloth;
    private static readonly IntPtr NativeFieldInfoPtr_useHead;
    private static readonly IntPtr NativeFieldInfoPtr_useArms;
    private static readonly IntPtr NativeFieldInfoPtr_useTorso;
    private static readonly IntPtr NativeFieldInfoPtr_useLegs;
    private static readonly IntPtr NativeFieldInfoPtr_useCloak;
    private static readonly IntPtr NativeFieldInfoPtr_useMount;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridEquipmentSkinnedMesh()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridEquipmentSkinnedMesh>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridEquipmentSkinnedMesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridEquipmentSkinnedMesh()
    {
      Il2CppClassPointerStore<HybridEquipmentSkinnedMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HybridEquipmentSkinnedMesh));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridEquipmentSkinnedMesh>.NativeClassPtr);
      HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_magicaMeshCloth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentSkinnedMesh>.NativeClassPtr, nameof (magicaMeshCloth));
      HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentSkinnedMesh>.NativeClassPtr, nameof (useHead));
      HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useArms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentSkinnedMesh>.NativeClassPtr, nameof (useArms));
      HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useTorso = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentSkinnedMesh>.NativeClassPtr, nameof (useTorso));
      HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useLegs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentSkinnedMesh>.NativeClassPtr, nameof (useLegs));
      HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useCloak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentSkinnedMesh>.NativeClassPtr, nameof (useCloak));
      HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentSkinnedMesh>.NativeClassPtr, nameof (useMount));
      HybridEquipmentSkinnedMesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridEquipmentSkinnedMesh>.NativeClassPtr, 100681874);
    }

    public HybridEquipmentSkinnedMesh(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MagicaMeshCloth magicaMeshCloth
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_magicaMeshCloth));
        return pointer == IntPtr.Zero ? (MagicaMeshCloth) null : new MagicaMeshCloth(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_magicaMeshCloth), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool useHead
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useHead));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useHead)) = value;
      }
    }

    public unsafe bool useArms
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useArms));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useArms)) = value;
      }
    }

    public unsafe bool useTorso
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useTorso));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useTorso)) = value;
      }
    }

    public unsafe bool useLegs
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useLegs));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useLegs)) = value;
      }
    }

    public unsafe bool useCloak
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useCloak));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useCloak)) = value;
      }
    }

    public unsafe bool useMount
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useMount));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentSkinnedMesh.NativeFieldInfoPtr_useMount)) = value;
      }
    }
  }
}
