// Decompiled with JetBrains decompiler
// Type: ProjectM.ManagedAchievementData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class ManagedAchievementData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Quest;
    private static readonly System.IntPtr NativeFieldInfoPtr_Flavor;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideRewardText;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ManagedAchievementData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ManagedAchievementData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedAchievementData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ManagedAchievementData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ManagedAchievementData()
    {
      Il2CppClassPointerStore<ManagedAchievementData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ManagedAchievementData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedAchievementData>.NativeClassPtr);
      ManagedAchievementData.NativeFieldInfoPtr_Quest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedAchievementData>.NativeClassPtr, nameof (Quest));
      ManagedAchievementData.NativeFieldInfoPtr_Flavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedAchievementData>.NativeClassPtr, nameof (Flavor));
      ManagedAchievementData.NativeFieldInfoPtr_OverrideRewardText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedAchievementData>.NativeClassPtr, nameof (OverrideRewardText));
      ManagedAchievementData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAchievementData>.NativeClassPtr, 100677014);
      ManagedAchievementData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedAchievementData>.NativeClassPtr, 100677015);
    }

    public ManagedAchievementData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey Quest
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedAchievementData.NativeFieldInfoPtr_Quest));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedAchievementData.NativeFieldInfoPtr_Quest)) = value;
      }
    }

    public unsafe LocalizationKey Flavor
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedAchievementData.NativeFieldInfoPtr_Flavor));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedAchievementData.NativeFieldInfoPtr_Flavor)) = value;
      }
    }

    public unsafe LocalizationKey OverrideRewardText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedAchievementData.NativeFieldInfoPtr_OverrideRewardText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedAchievementData.NativeFieldInfoPtr_OverrideRewardText)) = value;
      }
    }
  }
}
