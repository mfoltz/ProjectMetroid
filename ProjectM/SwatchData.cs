// Decompiled with JetBrains decompiler
// Type: SwatchData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
[Serializable]
public class SwatchData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Material;
  private static readonly System.IntPtr NativeFieldInfoPtr_OriginalMaterialColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_Color;
  private static readonly System.IntPtr NativeFieldInfoPtr_EndColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_Type;
  private static readonly System.IntPtr NativeFieldInfoPtr_VFXSetType;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(3875)]
  [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SwatchData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwatchData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SwatchData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SwatchData()
  {
    Il2CppClassPointerStore<SwatchData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (SwatchData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwatchData>.NativeClassPtr);
    SwatchData.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwatchData>.NativeClassPtr, nameof (Material));
    SwatchData.NativeFieldInfoPtr_OriginalMaterialColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwatchData>.NativeClassPtr, nameof (OriginalMaterialColor));
    SwatchData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwatchData>.NativeClassPtr, nameof (Color));
    SwatchData.NativeFieldInfoPtr_EndColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwatchData>.NativeClassPtr, nameof (EndColor));
    SwatchData.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwatchData>.NativeClassPtr, nameof (Type));
    SwatchData.NativeFieldInfoPtr_VFXSetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwatchData>.NativeClassPtr, nameof (VFXSetType));
    SwatchData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchData>.NativeClassPtr, 100663374);
  }

  public SwatchData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Material Material
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchData.NativeFieldInfoPtr_Material));
      return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SwatchData.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float4 OriginalMaterialColor
  {
    get
    {
      return *(float4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchData.NativeFieldInfoPtr_OriginalMaterialColor));
    }
    [param: In] set
    {
      *(float4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchData.NativeFieldInfoPtr_OriginalMaterialColor)) = value;
    }
  }

  public unsafe float4 Color
  {
    get
    {
      return *(float4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchData.NativeFieldInfoPtr_Color));
    }
    [param: In] set
    {
      *(float4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchData.NativeFieldInfoPtr_Color)) = value;
    }
  }

  public unsafe float4 EndColor
  {
    get
    {
      return *(float4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchData.NativeFieldInfoPtr_EndColor));
    }
    [param: In] set
    {
      *(float4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchData.NativeFieldInfoPtr_EndColor)) = value;
    }
  }

  public unsafe SwatchType Type
  {
    get
    {
      return *(SwatchType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchData.NativeFieldInfoPtr_Type));
    }
    [param: In] set
    {
      *(SwatchType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchData.NativeFieldInfoPtr_Type)) = value;
    }
  }

  public unsafe VFXColorSetType VFXSetType
  {
    get
    {
      return *(VFXColorSetType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchData.NativeFieldInfoPtr_VFXSetType));
    }
    [param: In] set
    {
      *(VFXColorSetType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchData.NativeFieldInfoPtr_VFXSetType)) = value;
    }
  }
}
