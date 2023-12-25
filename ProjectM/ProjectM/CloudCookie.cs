// Decompiled with JetBrains decompiler
// Type: ProjectM.CloudCookie
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
  public struct CloudCookie
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Alpha;
    private static readonly System.IntPtr NativeFieldInfoPtr_Size;
    private static readonly System.IntPtr NativeFieldInfoPtr_Scale;
    private static readonly System.IntPtr NativeFieldInfoPtr_VolumetricMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_WrapMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextureIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_MipLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_InvertColors;
    [FieldOffset(0)]
    public float2 Speed;
    [FieldOffset(8)]
    public float Alpha;
    [FieldOffset(12)]
    public float Size;
    [FieldOffset(16)]
    public float Scale;
    [FieldOffset(20)]
    public float VolumetricMultiplier;
    [FieldOffset(24)]
    public CloudWrapModeEnum WrapMode;
    [FieldOffset(25)]
    public byte TextureIndex;
    [FieldOffset(26)]
    public byte MipLevel;
    [FieldOffset(27)]
    public bool InvertColors;

    static CloudCookie()
    {
      Il2CppClassPointerStore<CloudCookie>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CloudCookie));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloudCookie>.NativeClassPtr);
      CloudCookie.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookie>.NativeClassPtr, nameof (Speed));
      CloudCookie.NativeFieldInfoPtr_Alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookie>.NativeClassPtr, nameof (Alpha));
      CloudCookie.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookie>.NativeClassPtr, nameof (Size));
      CloudCookie.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookie>.NativeClassPtr, nameof (Scale));
      CloudCookie.NativeFieldInfoPtr_VolumetricMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookie>.NativeClassPtr, nameof (VolumetricMultiplier));
      CloudCookie.NativeFieldInfoPtr_WrapMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookie>.NativeClassPtr, nameof (WrapMode));
      CloudCookie.NativeFieldInfoPtr_TextureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookie>.NativeClassPtr, nameof (TextureIndex));
      CloudCookie.NativeFieldInfoPtr_MipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookie>.NativeClassPtr, nameof (MipLevel));
      CloudCookie.NativeFieldInfoPtr_InvertColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookie>.NativeClassPtr, nameof (InvertColors));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CloudCookie>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
