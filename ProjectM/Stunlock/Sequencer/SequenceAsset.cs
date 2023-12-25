// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.SequenceAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace Stunlock.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SequenceAsset
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceBlobRef;
    [FieldOffset(0)]
    public BlobAssetReference<SequenceBlob> SequenceBlobRef;

    static SequenceAsset()
    {
      Il2CppClassPointerStore<SequenceAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (SequenceAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceAsset>.NativeClassPtr);
      SequenceAsset.NativeFieldInfoPtr_SequenceBlobRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceAsset>.NativeClassPtr, nameof (SequenceBlobRef));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SequenceAsset>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
