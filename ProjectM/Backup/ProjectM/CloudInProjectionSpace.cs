// Decompiled with JetBrains decompiler
// Type: ProjectM.CloudInProjectionSpace
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CloudInProjectionSpace
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position2D;
    private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_SizeUV;
    private static readonly System.IntPtr NativeFieldInfoPtr_HalfSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_Alpha;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextureIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_MipLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_Wrap;
    private static readonly System.IntPtr NativeFieldInfoPtr_InvertColors;
    private static readonly System.IntPtr NativeFieldInfoPtr_VolumetricMultiplier;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public float2 Position2D;
    [FieldOffset(8)]
    public float2 Speed;
    [FieldOffset(16)]
    public float SizeUV;
    [FieldOffset(20)]
    public float HalfSize;
    [FieldOffset(24)]
    public float Alpha;
    [FieldOffset(28)]
    public int TextureIndex;
    [FieldOffset(32)]
    public int MipLevel;
    [FieldOffset(36)]
    public int Wrap;
    [FieldOffset(40)]
    public int InvertColors;
    [FieldOffset(44)]
    public float VolumetricMultiplier;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987209, XrefRangeEnd = 987218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CloudInProjectionSpace.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static CloudInProjectionSpace()
    {
      Il2CppClassPointerStore<CloudInProjectionSpace>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CloudInProjectionSpace));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloudInProjectionSpace>.NativeClassPtr);
      CloudInProjectionSpace.NativeFieldInfoPtr_Position2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudInProjectionSpace>.NativeClassPtr, nameof (Position2D));
      CloudInProjectionSpace.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudInProjectionSpace>.NativeClassPtr, nameof (Speed));
      CloudInProjectionSpace.NativeFieldInfoPtr_SizeUV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudInProjectionSpace>.NativeClassPtr, nameof (SizeUV));
      CloudInProjectionSpace.NativeFieldInfoPtr_HalfSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudInProjectionSpace>.NativeClassPtr, nameof (HalfSize));
      CloudInProjectionSpace.NativeFieldInfoPtr_Alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudInProjectionSpace>.NativeClassPtr, nameof (Alpha));
      CloudInProjectionSpace.NativeFieldInfoPtr_TextureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudInProjectionSpace>.NativeClassPtr, nameof (TextureIndex));
      CloudInProjectionSpace.NativeFieldInfoPtr_MipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudInProjectionSpace>.NativeClassPtr, nameof (MipLevel));
      CloudInProjectionSpace.NativeFieldInfoPtr_Wrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudInProjectionSpace>.NativeClassPtr, nameof (Wrap));
      CloudInProjectionSpace.NativeFieldInfoPtr_InvertColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudInProjectionSpace>.NativeClassPtr, nameof (InvertColors));
      CloudInProjectionSpace.NativeFieldInfoPtr_VolumetricMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudInProjectionSpace>.NativeClassPtr, nameof (VolumetricMultiplier));
      CloudInProjectionSpace.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudInProjectionSpace>.NativeClassPtr, 100676149);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CloudInProjectionSpace>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
