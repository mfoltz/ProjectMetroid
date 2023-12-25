// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTree
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BehaviourTree
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Blob;
    [FieldOffset(0)]
    public BlobAssetReference<BehaviourTreeBlob> Blob;

    static BehaviourTree()
    {
      Il2CppClassPointerStore<BehaviourTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (BehaviourTree));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTree>.NativeClassPtr);
      BehaviourTree.NativeFieldInfoPtr_Blob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTree>.NativeClassPtr, nameof (Blob));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTree>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
