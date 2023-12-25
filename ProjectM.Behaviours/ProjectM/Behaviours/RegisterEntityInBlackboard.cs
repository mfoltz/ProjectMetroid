// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.RegisterEntityInBlackboard
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
  public struct RegisterEntityInBlackboard
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public int Index;

    static RegisterEntityInBlackboard()
    {
      Il2CppClassPointerStore<RegisterEntityInBlackboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (RegisterEntityInBlackboard));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterEntityInBlackboard>.NativeClassPtr);
      RegisterEntityInBlackboard.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEntityInBlackboard>.NativeClassPtr, nameof (Entity));
      RegisterEntityInBlackboard.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEntityInBlackboard>.NativeClassPtr, nameof (Index));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterEntityInBlackboard>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
