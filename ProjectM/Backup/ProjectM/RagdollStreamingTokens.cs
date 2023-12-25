// Decompiled with JetBrains decompiler
// Type: ProjectM.RagdollStreamingTokens
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RagdollStreamingTokens
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideToken;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseToken;
    [FieldOffset(0)]
    public AssetReferenceToken OverrideToken;
    [FieldOffset(28)]
    public AssetReferenceToken BaseToken;

    static RagdollStreamingTokens()
    {
      Il2CppClassPointerStore<RagdollStreamingTokens>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RagdollStreamingTokens));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollStreamingTokens>.NativeClassPtr);
      RagdollStreamingTokens.NativeFieldInfoPtr_OverrideToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollStreamingTokens>.NativeClassPtr, nameof (OverrideToken));
      RagdollStreamingTokens.NativeFieldInfoPtr_BaseToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollStreamingTokens>.NativeClassPtr, nameof (BaseToken));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RagdollStreamingTokens>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
