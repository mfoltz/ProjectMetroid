// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.VFXSwatchChangeInstruction
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class VFXSwatchChangeInstruction : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Renderer;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_VFXSetType;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyAlpha;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VFXSwatchChangeInstruction()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXSwatchChangeInstruction>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VFXSwatchChangeInstruction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VFXSwatchChangeInstruction()
    {
      Il2CppClassPointerStore<VFXSwatchChangeInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (VFXSwatchChangeInstruction));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXSwatchChangeInstruction>.NativeClassPtr);
      VFXSwatchChangeInstruction.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXSwatchChangeInstruction>.NativeClassPtr, nameof (Renderer));
      VFXSwatchChangeInstruction.NativeFieldInfoPtr_StartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXSwatchChangeInstruction>.NativeClassPtr, nameof (StartColor));
      VFXSwatchChangeInstruction.NativeFieldInfoPtr_EndColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXSwatchChangeInstruction>.NativeClassPtr, nameof (EndColor));
      VFXSwatchChangeInstruction.NativeFieldInfoPtr_VFXSetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXSwatchChangeInstruction>.NativeClassPtr, nameof (VFXSetType));
      VFXSwatchChangeInstruction.NativeFieldInfoPtr_CopyAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXSwatchChangeInstruction>.NativeClassPtr, nameof (CopyAlpha));
      VFXSwatchChangeInstruction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSwatchChangeInstruction>.NativeClassPtr, 100689756);
    }

    public VFXSwatchChangeInstruction(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Renderer Renderer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXSwatchChangeInstruction.NativeFieldInfoPtr_Renderer));
        return pointer == System.IntPtr.Zero ? (Renderer) null : new Renderer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXSwatchChangeInstruction.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color StartColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXSwatchChangeInstruction.NativeFieldInfoPtr_StartColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXSwatchChangeInstruction.NativeFieldInfoPtr_StartColor)) = value;
      }
    }

    public unsafe Color EndColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXSwatchChangeInstruction.NativeFieldInfoPtr_EndColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXSwatchChangeInstruction.NativeFieldInfoPtr_EndColor)) = value;
      }
    }

    public unsafe VFXColorSetType VFXSetType
    {
      get
      {
        return *(VFXColorSetType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXSwatchChangeInstruction.NativeFieldInfoPtr_VFXSetType));
      }
      [param: In] set
      {
        *(VFXColorSetType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXSwatchChangeInstruction.NativeFieldInfoPtr_VFXSetType)) = value;
      }
    }

    public unsafe bool CopyAlpha
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXSwatchChangeInstruction.NativeFieldInfoPtr_CopyAlpha));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXSwatchChangeInstruction.NativeFieldInfoPtr_CopyAlpha)) = value;
      }
    }
  }
}
