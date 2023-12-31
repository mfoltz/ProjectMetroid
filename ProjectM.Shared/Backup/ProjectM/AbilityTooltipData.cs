// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityTooltipData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.UI;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class AbilityTooltipData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Description;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipType;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnPrefabOnCast;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityTooltipData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityTooltipData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityTooltipData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityTooltipData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityTooltipData()
    {
      Il2CppClassPointerStore<AbilityTooltipData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityTooltipData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityTooltipData>.NativeClassPtr);
      AbilityTooltipData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltipData>.NativeClassPtr, nameof (Name));
      AbilityTooltipData.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltipData>.NativeClassPtr, nameof (Description));
      AbilityTooltipData.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltipData>.NativeClassPtr, nameof (Icon));
      AbilityTooltipData.NativeFieldInfoPtr_TooltipType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltipData>.NativeClassPtr, nameof (TooltipType));
      AbilityTooltipData.NativeFieldInfoPtr_SpawnPrefabOnCast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTooltipData>.NativeClassPtr, nameof (SpawnPrefabOnCast));
      AbilityTooltipData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityTooltipData>.NativeClassPtr, 100664110);
      AbilityTooltipData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityTooltipData>.NativeClassPtr, 100664111);
    }

    public AbilityTooltipData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltipData.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltipData.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe LocalizedStringBuilderBase Description
    {
      get
      {
        return *(LocalizedStringBuilderBase*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltipData.NativeFieldInfoPtr_Description));
      }
      [param: In] set
      {
        *(LocalizedStringBuilderBase*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltipData.NativeFieldInfoPtr_Description)) = value;
      }
    }

    public unsafe Sprite Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltipData.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltipData.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AbilityTooltipType TooltipType
    {
      get
      {
        return *(AbilityTooltipType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltipData.NativeFieldInfoPtr_TooltipType));
      }
      [param: In] set
      {
        *(AbilityTooltipType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltipData.NativeFieldInfoPtr_TooltipType)) = value;
      }
    }

    public unsafe PrefabGUID SpawnPrefabOnCast
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltipData.NativeFieldInfoPtr_SpawnPrefabOnCast));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityTooltipData.NativeFieldInfoPtr_SpawnPrefabOnCast)) = value;
      }
    }
  }
}
