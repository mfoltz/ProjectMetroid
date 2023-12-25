// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.JournalCategory
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public class JournalCategory : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CategoryType;
    private static readonly System.IntPtr NativeFieldInfoPtr_CategoryName;
    private static readonly System.IntPtr NativeFieldInfoPtr_Active;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214804, XrefRangeEnd = 1214805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe JournalCategory()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalCategory>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static JournalCategory()
    {
      Il2CppClassPointerStore<JournalCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (JournalCategory));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalCategory>.NativeClassPtr);
      JournalCategory.NativeFieldInfoPtr_CategoryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCategory>.NativeClassPtr, nameof (CategoryType));
      JournalCategory.NativeFieldInfoPtr_CategoryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCategory>.NativeClassPtr, nameof (CategoryName));
      JournalCategory.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCategory>.NativeClassPtr, nameof (Active));
      JournalCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCategory>.NativeClassPtr, 100664078);
    }

    public JournalCategory(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe JournalCategoryType CategoryType
    {
      get
      {
        return *(JournalCategoryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCategory.NativeFieldInfoPtr_CategoryType));
      }
      [param: In] set
      {
        *(JournalCategoryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCategory.NativeFieldInfoPtr_CategoryType)) = value;
      }
    }

    public unsafe LocalizationKey CategoryName
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCategory.NativeFieldInfoPtr_CategoryName));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCategory.NativeFieldInfoPtr_CategoryName)) = value;
      }
    }

    public unsafe bool Active
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCategory.NativeFieldInfoPtr_Active));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCategory.NativeFieldInfoPtr_Active)) = value;
      }
    }
  }
}
