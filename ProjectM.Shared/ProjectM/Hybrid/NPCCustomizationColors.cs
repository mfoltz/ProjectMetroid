// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.NPCCustomizationColors
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  public class NPCCustomizationColors : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SkinColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_HairColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_EyeColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExtraColor;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NPCCustomizationColors()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCCustomizationColors>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NPCCustomizationColors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NPCCustomizationColors()
    {
      Il2CppClassPointerStore<NPCCustomizationColors>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Hybrid", nameof (NPCCustomizationColors));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCCustomizationColors>.NativeClassPtr);
      NPCCustomizationColors.NativeFieldInfoPtr_SkinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCCustomizationColors>.NativeClassPtr, nameof (SkinColor));
      NPCCustomizationColors.NativeFieldInfoPtr_HairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCCustomizationColors>.NativeClassPtr, nameof (HairColor));
      NPCCustomizationColors.NativeFieldInfoPtr_EyeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCCustomizationColors>.NativeClassPtr, nameof (EyeColor));
      NPCCustomizationColors.NativeFieldInfoPtr_ExtraColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCCustomizationColors>.NativeClassPtr, nameof (ExtraColor));
      NPCCustomizationColors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCCustomizationColors>.NativeClassPtr, 100670253);
    }

    public NPCCustomizationColors(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Color SkinColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCCustomizationColors.NativeFieldInfoPtr_SkinColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCCustomizationColors.NativeFieldInfoPtr_SkinColor)) = value;
      }
    }

    public unsafe Color HairColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCCustomizationColors.NativeFieldInfoPtr_HairColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCCustomizationColors.NativeFieldInfoPtr_HairColor)) = value;
      }
    }

    public unsafe Color EyeColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCCustomizationColors.NativeFieldInfoPtr_EyeColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCCustomizationColors.NativeFieldInfoPtr_EyeColor)) = value;
      }
    }

    public unsafe Color ExtraColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCCustomizationColors.NativeFieldInfoPtr_ExtraColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NPCCustomizationColors.NativeFieldInfoPtr_ExtraColor)) = value;
      }
    }
  }
}
