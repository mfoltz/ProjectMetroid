// Decompiled with JetBrains decompiler
// Type: ProjectM.CharacterCustomizationSettingsComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CharacterCustomizationSettingsComponent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SkintoneColorCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_EyeColorCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_HairColorCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaleFacesCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaleHairsCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaleFeaturesCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaleAccessoriesCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FemaleFacesCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FemaleHairsCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FemaleFeaturesCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FemaleAccessoriesCount;
    [FieldOffset(0)]
    public byte SkintoneColorCount;
    [FieldOffset(1)]
    public byte EyeColorCount;
    [FieldOffset(2)]
    public byte HairColorCount;
    [FieldOffset(3)]
    public byte MaleFacesCount;
    [FieldOffset(4)]
    public byte MaleHairsCount;
    [FieldOffset(5)]
    public byte MaleFeaturesCount;
    [FieldOffset(6)]
    public byte MaleAccessoriesCount;
    [FieldOffset(7)]
    public byte FemaleFacesCount;
    [FieldOffset(8)]
    public byte FemaleHairsCount;
    [FieldOffset(9)]
    public byte FemaleFeaturesCount;
    [FieldOffset(10)]
    public byte FemaleAccessoriesCount;

    static CharacterCustomizationSettingsComponent()
    {
      Il2CppClassPointerStore<CharacterCustomizationSettingsComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CharacterCustomizationSettingsComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationSettingsComponent>.NativeClassPtr);
      CharacterCustomizationSettingsComponent.NativeFieldInfoPtr_SkintoneColorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettingsComponent>.NativeClassPtr, nameof (SkintoneColorCount));
      CharacterCustomizationSettingsComponent.NativeFieldInfoPtr_EyeColorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettingsComponent>.NativeClassPtr, nameof (EyeColorCount));
      CharacterCustomizationSettingsComponent.NativeFieldInfoPtr_HairColorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettingsComponent>.NativeClassPtr, nameof (HairColorCount));
      CharacterCustomizationSettingsComponent.NativeFieldInfoPtr_MaleFacesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettingsComponent>.NativeClassPtr, nameof (MaleFacesCount));
      CharacterCustomizationSettingsComponent.NativeFieldInfoPtr_MaleHairsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettingsComponent>.NativeClassPtr, nameof (MaleHairsCount));
      CharacterCustomizationSettingsComponent.NativeFieldInfoPtr_MaleFeaturesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettingsComponent>.NativeClassPtr, nameof (MaleFeaturesCount));
      CharacterCustomizationSettingsComponent.NativeFieldInfoPtr_MaleAccessoriesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettingsComponent>.NativeClassPtr, nameof (MaleAccessoriesCount));
      CharacterCustomizationSettingsComponent.NativeFieldInfoPtr_FemaleFacesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettingsComponent>.NativeClassPtr, nameof (FemaleFacesCount));
      CharacterCustomizationSettingsComponent.NativeFieldInfoPtr_FemaleHairsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettingsComponent>.NativeClassPtr, nameof (FemaleHairsCount));
      CharacterCustomizationSettingsComponent.NativeFieldInfoPtr_FemaleFeaturesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettingsComponent>.NativeClassPtr, nameof (FemaleFeaturesCount));
      CharacterCustomizationSettingsComponent.NativeFieldInfoPtr_FemaleAccessoriesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettingsComponent>.NativeClassPtr, nameof (FemaleAccessoriesCount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterCustomizationSettingsComponent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
