// Decompiled with JetBrains decompiler
// Type: Swatch
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
[Serializable]
public class Swatch : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Material;
  private static readonly System.IntPtr NativeFieldInfoPtr_SwatchName;
  private static readonly System.IntPtr NativeFieldInfoPtr_SwatchGuid;
  private static readonly System.IntPtr NativeFieldInfoPtr_Color;
  private static readonly System.IntPtr NativeFieldInfoPtr_EndColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_Type;
  private static readonly System.IntPtr NativeFieldInfoPtr_VFXSetType;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912282, XrefRangeEnd = 912292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Swatch()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Swatch>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Swatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Swatch()
  {
    Il2CppClassPointerStore<Swatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (Swatch));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Swatch>.NativeClassPtr);
    Swatch.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swatch>.NativeClassPtr, nameof (Material));
    Swatch.NativeFieldInfoPtr_SwatchName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swatch>.NativeClassPtr, nameof (SwatchName));
    Swatch.NativeFieldInfoPtr_SwatchGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swatch>.NativeClassPtr, nameof (SwatchGuid));
    Swatch.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swatch>.NativeClassPtr, nameof (Color));
    Swatch.NativeFieldInfoPtr_EndColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swatch>.NativeClassPtr, nameof (EndColor));
    Swatch.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swatch>.NativeClassPtr, nameof (Type));
    Swatch.NativeFieldInfoPtr_VFXSetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Swatch>.NativeClassPtr, nameof (VFXSetType));
    Swatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Swatch>.NativeClassPtr, 100663373);
  }

  public Swatch(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Material Material
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swatch.NativeFieldInfoPtr_Material));
      return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Swatch.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string SwatchName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swatch.NativeFieldInfoPtr_SwatchName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Swatch.NativeFieldInfoPtr_SwatchName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string SwatchGuid
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swatch.NativeFieldInfoPtr_SwatchGuid)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Swatch.NativeFieldInfoPtr_SwatchGuid), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Color Color
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swatch.NativeFieldInfoPtr_Color));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swatch.NativeFieldInfoPtr_Color)) = value;
    }
  }

  public unsafe Color EndColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swatch.NativeFieldInfoPtr_EndColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swatch.NativeFieldInfoPtr_EndColor)) = value;
    }
  }

  public unsafe SwatchType Type
  {
    get
    {
      return *(SwatchType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swatch.NativeFieldInfoPtr_Type));
    }
    [param: In] set
    {
      *(SwatchType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swatch.NativeFieldInfoPtr_Type)) = value;
    }
  }

  public unsafe VFXColorSetType VFXSetType
  {
    get
    {
      return *(VFXColorSetType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swatch.NativeFieldInfoPtr_VFXSetType));
    }
    [param: In] set
    {
      *(VFXColorSetType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Swatch.NativeFieldInfoPtr_VFXSetType)) = value;
    }
  }
}
