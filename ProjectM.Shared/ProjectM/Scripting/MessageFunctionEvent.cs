// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.MessageFunctionEvent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MessageFunctionEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FunctionNameHash;
    [FieldOffset(0)]
    public Entity TargetEntity;
    [FieldOffset(8)]
    public int FunctionNameHash;

    static MessageFunctionEvent()
    {
      Il2CppClassPointerStore<MessageFunctionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (MessageFunctionEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageFunctionEvent>.NativeClassPtr);
      MessageFunctionEvent.NativeFieldInfoPtr_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageFunctionEvent>.NativeClassPtr, nameof (TargetEntity));
      MessageFunctionEvent.NativeFieldInfoPtr_FunctionNameHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageFunctionEvent>.NativeClassPtr, nameof (FunctionNameHash));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MessageFunctionEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
