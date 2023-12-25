// Decompiled with JetBrains decompiler
// Type: ProjectM.CheckOnScreen
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CheckOnScreen
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ScreenPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_PixelOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistanceForHudAndFadeOut;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreLineOfSight;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsOnScreen;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasLineOfSight;
    [FieldOffset(0)]
    public float3 ScreenPosition;
    [FieldOffset(12)]
    public float PixelOffset;
    [FieldOffset(16)]
    public float MaxDistanceForHudAndFadeOut;
    [FieldOffset(20)]
    public bool IgnoreLineOfSight;
    [FieldOffset(21)]
    public bool IsOnScreen;
    [FieldOffset(22)]
    public bool HasLineOfSight;

    static CheckOnScreen()
    {
      Il2CppClassPointerStore<CheckOnScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CheckOnScreen));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckOnScreen>.NativeClassPtr);
      CheckOnScreen.NativeFieldInfoPtr_ScreenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckOnScreen>.NativeClassPtr, nameof (ScreenPosition));
      CheckOnScreen.NativeFieldInfoPtr_PixelOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckOnScreen>.NativeClassPtr, nameof (PixelOffset));
      CheckOnScreen.NativeFieldInfoPtr_MaxDistanceForHudAndFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckOnScreen>.NativeClassPtr, nameof (MaxDistanceForHudAndFadeOut));
      CheckOnScreen.NativeFieldInfoPtr_IgnoreLineOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckOnScreen>.NativeClassPtr, nameof (IgnoreLineOfSight));
      CheckOnScreen.NativeFieldInfoPtr_IsOnScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckOnScreen>.NativeClassPtr, nameof (IsOnScreen));
      CheckOnScreen.NativeFieldInfoPtr_HasLineOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckOnScreen>.NativeClassPtr, nameof (HasLineOfSight));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CheckOnScreen>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
