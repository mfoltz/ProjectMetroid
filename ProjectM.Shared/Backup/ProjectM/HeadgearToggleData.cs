// Decompiled with JetBrains decompiler
// Type: ProjectM.HeadgearToggleData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HeadgearToggleData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HideCharacterHairOnEquip;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideCharacterFacialFeaturesOnEquip;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideCharacterHeadOnEquip;
    [FieldOffset(0)]
    public bool HideCharacterHairOnEquip;
    [FieldOffset(1)]
    public bool HideCharacterFacialFeaturesOnEquip;
    [FieldOffset(2)]
    public bool HideCharacterHeadOnEquip;

    static HeadgearToggleData()
    {
      Il2CppClassPointerStore<HeadgearToggleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (HeadgearToggleData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeadgearToggleData>.NativeClassPtr);
      HeadgearToggleData.NativeFieldInfoPtr_HideCharacterHairOnEquip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadgearToggleData>.NativeClassPtr, nameof (HideCharacterHairOnEquip));
      HeadgearToggleData.NativeFieldInfoPtr_HideCharacterFacialFeaturesOnEquip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadgearToggleData>.NativeClassPtr, nameof (HideCharacterFacialFeaturesOnEquip));
      HeadgearToggleData.NativeFieldInfoPtr_HideCharacterHeadOnEquip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadgearToggleData>.NativeClassPtr, nameof (HideCharacterHeadOnEquip));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HeadgearToggleData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
