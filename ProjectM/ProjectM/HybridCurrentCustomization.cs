// Decompiled with JetBrains decompiler
// Type: ProjectM.HybridCurrentCustomization
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HybridCurrentCustomization
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SkintoneIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FaceIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_EyeColorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_HairStyleIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_HairColorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FeaturesIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_AccessoriesIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDefault_Public_Static_HybridCurrentCustomization_0;
    [FieldOffset(0)]
    public int SkintoneIndex;
    [FieldOffset(4)]
    public int FaceIndex;
    [FieldOffset(8)]
    public int EyeColorIndex;
    [FieldOffset(12)]
    public int HairStyleIndex;
    [FieldOffset(16)]
    public int HairColorIndex;
    [FieldOffset(20)]
    public int FeaturesIndex;
    [FieldOffset(24)]
    public int AccessoriesIndex;

    [CallerCount(0)]
    public static unsafe HybridCurrentCustomization GetDefault()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCurrentCustomization.NativeMethodInfoPtr_GetDefault_Public_Static_HybridCurrentCustomization_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(HybridCurrentCustomization*) IL2CPP.il2cpp_object_unbox(num);
    }

    static HybridCurrentCustomization()
    {
      Il2CppClassPointerStore<HybridCurrentCustomization>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HybridCurrentCustomization));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridCurrentCustomization>.NativeClassPtr);
      HybridCurrentCustomization.NativeFieldInfoPtr_SkintoneIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentCustomization>.NativeClassPtr, nameof (SkintoneIndex));
      HybridCurrentCustomization.NativeFieldInfoPtr_FaceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentCustomization>.NativeClassPtr, nameof (FaceIndex));
      HybridCurrentCustomization.NativeFieldInfoPtr_EyeColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentCustomization>.NativeClassPtr, nameof (EyeColorIndex));
      HybridCurrentCustomization.NativeFieldInfoPtr_HairStyleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentCustomization>.NativeClassPtr, nameof (HairStyleIndex));
      HybridCurrentCustomization.NativeFieldInfoPtr_HairColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentCustomization>.NativeClassPtr, nameof (HairColorIndex));
      HybridCurrentCustomization.NativeFieldInfoPtr_FeaturesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentCustomization>.NativeClassPtr, nameof (FeaturesIndex));
      HybridCurrentCustomization.NativeFieldInfoPtr_AccessoriesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentCustomization>.NativeClassPtr, nameof (AccessoriesIndex));
      HybridCurrentCustomization.NativeMethodInfoPtr_GetDefault_Public_Static_HybridCurrentCustomization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCurrentCustomization>.NativeClassPtr, 100681884);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridCurrentCustomization>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
