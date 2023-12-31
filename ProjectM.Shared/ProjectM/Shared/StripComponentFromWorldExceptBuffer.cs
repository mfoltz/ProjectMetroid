// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.StripComponentFromWorldExceptBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StripComponentFromWorldExceptBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StableTypeHash;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldType;
    [FieldOffset(0)]
    public ulong StableTypeHash;
    [FieldOffset(8)]
    public WorldType WorldType;

    static StripComponentFromWorldExceptBuffer()
    {
      Il2CppClassPointerStore<StripComponentFromWorldExceptBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (StripComponentFromWorldExceptBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StripComponentFromWorldExceptBuffer>.NativeClassPtr);
      StripComponentFromWorldExceptBuffer.NativeFieldInfoPtr_StableTypeHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StripComponentFromWorldExceptBuffer>.NativeClassPtr, nameof (StableTypeHash));
      StripComponentFromWorldExceptBuffer.NativeFieldInfoPtr_WorldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StripComponentFromWorldExceptBuffer>.NativeClassPtr, nameof (WorldType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StripComponentFromWorldExceptBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
