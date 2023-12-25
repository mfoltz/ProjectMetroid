// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModelStreamingTokens
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Hybrid
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HybridModelStreamingTokens
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideToken;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseToken;
    [FieldOffset(0)]
    public AssetReferenceToken OverrideToken;
    [FieldOffset(28)]
    public AssetReferenceToken BaseToken;

    static HybridModelStreamingTokens()
    {
      Il2CppClassPointerStore<HybridModelStreamingTokens>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (HybridModelStreamingTokens));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelStreamingTokens>.NativeClassPtr);
      HybridModelStreamingTokens.NativeFieldInfoPtr_OverrideToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelStreamingTokens>.NativeClassPtr, nameof (OverrideToken));
      HybridModelStreamingTokens.NativeFieldInfoPtr_BaseToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelStreamingTokens>.NativeClassPtr, nameof (BaseToken));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelStreamingTokens>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
