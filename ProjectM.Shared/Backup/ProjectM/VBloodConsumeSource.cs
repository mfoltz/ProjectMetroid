// Decompiled with JetBrains decompiler
// Type: ProjectM.VBloodConsumeSource
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VBloodConsumeSource
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Source;
    private static readonly System.IntPtr NativeFieldInfoPtr_JournalCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_QuestFlavorTextOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipGUID;
    [FieldOffset(0)]
    public PrefabGUID Source;
    [FieldOffset(4)]
    public JournalCategoryType JournalCategory;
    [FieldOffset(8)]
    public LocalizationKey QuestFlavorTextOverride;
    [FieldOffset(24)]
    public PrefabGUID TooltipGUID;

    static VBloodConsumeSource()
    {
      Il2CppClassPointerStore<VBloodConsumeSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (VBloodConsumeSource));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodConsumeSource>.NativeClassPtr);
      VBloodConsumeSource.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodConsumeSource>.NativeClassPtr, nameof (Source));
      VBloodConsumeSource.NativeFieldInfoPtr_JournalCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodConsumeSource>.NativeClassPtr, nameof (JournalCategory));
      VBloodConsumeSource.NativeFieldInfoPtr_QuestFlavorTextOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodConsumeSource>.NativeClassPtr, nameof (QuestFlavorTextOverride));
      VBloodConsumeSource.NativeFieldInfoPtr_TooltipGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodConsumeSource>.NativeClassPtr, nameof (TooltipGUID));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VBloodConsumeSource>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
