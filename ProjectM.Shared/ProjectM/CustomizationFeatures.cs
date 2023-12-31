// Decompiled with JetBrains decompiler
// Type: ProjectM.CustomizationFeatures
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CustomizationFeatures
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GenderIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_SkintoneIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FaceIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_EyeColorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_HairStyleIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_HairColorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FeaturesIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_AccessoriesIndex;
    [FieldOffset(0)]
    public byte GenderIndex;
    [FieldOffset(1)]
    public byte SkintoneIndex;
    [FieldOffset(2)]
    public byte FaceIndex;
    [FieldOffset(3)]
    public byte EyeColorIndex;
    [FieldOffset(4)]
    public byte HairStyleIndex;
    [FieldOffset(5)]
    public byte HairColorIndex;
    [FieldOffset(6)]
    public byte FeaturesIndex;
    [FieldOffset(7)]
    public byte AccessoriesIndex;

    static CustomizationFeatures()
    {
      Il2CppClassPointerStore<CustomizationFeatures>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CustomizationFeatures));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomizationFeatures>.NativeClassPtr);
      CustomizationFeatures.NativeFieldInfoPtr_GenderIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationFeatures>.NativeClassPtr, nameof (GenderIndex));
      CustomizationFeatures.NativeFieldInfoPtr_SkintoneIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationFeatures>.NativeClassPtr, nameof (SkintoneIndex));
      CustomizationFeatures.NativeFieldInfoPtr_FaceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationFeatures>.NativeClassPtr, nameof (FaceIndex));
      CustomizationFeatures.NativeFieldInfoPtr_EyeColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationFeatures>.NativeClassPtr, nameof (EyeColorIndex));
      CustomizationFeatures.NativeFieldInfoPtr_HairStyleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationFeatures>.NativeClassPtr, nameof (HairStyleIndex));
      CustomizationFeatures.NativeFieldInfoPtr_HairColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationFeatures>.NativeClassPtr, nameof (HairColorIndex));
      CustomizationFeatures.NativeFieldInfoPtr_FeaturesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationFeatures>.NativeClassPtr, nameof (FeaturesIndex));
      CustomizationFeatures.NativeFieldInfoPtr_AccessoriesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationFeatures>.NativeClassPtr, nameof (AccessoriesIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomizationFeatures>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
