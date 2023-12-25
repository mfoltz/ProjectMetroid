// Decompiled with JetBrains decompiler
// Type: ProjectM.VBloodClientDataTesting
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public sealed class VBloodClientDataTesting : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AchievementGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_QuestFlavorTextOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_JournalCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipText;
    private static readonly System.IntPtr NativeFieldInfoPtr_SortOrder;

    static VBloodClientDataTesting()
    {
      Il2CppClassPointerStore<VBloodClientDataTesting>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (VBloodClientDataTesting));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodClientDataTesting>.NativeClassPtr);
      VBloodClientDataTesting.NativeFieldInfoPtr_AchievementGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodClientDataTesting>.NativeClassPtr, nameof (AchievementGUID));
      VBloodClientDataTesting.NativeFieldInfoPtr_QuestFlavorTextOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodClientDataTesting>.NativeClassPtr, nameof (QuestFlavorTextOverride));
      VBloodClientDataTesting.NativeFieldInfoPtr_JournalCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodClientDataTesting>.NativeClassPtr, nameof (JournalCategory));
      VBloodClientDataTesting.NativeFieldInfoPtr_TooltipGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodClientDataTesting>.NativeClassPtr, nameof (TooltipGUID));
      VBloodClientDataTesting.NativeFieldInfoPtr_TooltipSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodClientDataTesting>.NativeClassPtr, nameof (TooltipSprite));
      VBloodClientDataTesting.NativeFieldInfoPtr_TooltipText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodClientDataTesting>.NativeClassPtr, nameof (TooltipText));
      VBloodClientDataTesting.NativeFieldInfoPtr_SortOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodClientDataTesting>.NativeClassPtr, nameof (SortOrder));
    }

    public VBloodClientDataTesting(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public VBloodClientDataTesting()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VBloodClientDataTesting>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VBloodClientDataTesting>.NativeClassPtr, data));
    }

    public unsafe PrefabGUID AchievementGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodClientDataTesting.NativeFieldInfoPtr_AchievementGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodClientDataTesting.NativeFieldInfoPtr_AchievementGUID)) = value;
      }
    }

    public unsafe LocalizationKey QuestFlavorTextOverride
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodClientDataTesting.NativeFieldInfoPtr_QuestFlavorTextOverride));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodClientDataTesting.NativeFieldInfoPtr_QuestFlavorTextOverride)) = value;
      }
    }

    public unsafe JournalCategoryType JournalCategory
    {
      get
      {
        return *(JournalCategoryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodClientDataTesting.NativeFieldInfoPtr_JournalCategory));
      }
      [param: In] set
      {
        *(JournalCategoryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodClientDataTesting.NativeFieldInfoPtr_JournalCategory)) = value;
      }
    }

    public unsafe PrefabGUID TooltipGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodClientDataTesting.NativeFieldInfoPtr_TooltipGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodClientDataTesting.NativeFieldInfoPtr_TooltipGUID)) = value;
      }
    }

    public unsafe Sprite TooltipSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodClientDataTesting.NativeFieldInfoPtr_TooltipSprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodClientDataTesting.NativeFieldInfoPtr_TooltipSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey TooltipText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodClientDataTesting.NativeFieldInfoPtr_TooltipText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodClientDataTesting.NativeFieldInfoPtr_TooltipText)) = value;
      }
    }

    public unsafe int SortOrder
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodClientDataTesting.NativeFieldInfoPtr_SortOrder));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodClientDataTesting.NativeFieldInfoPtr_SortOrder)) = value;
      }
    }
  }
}
