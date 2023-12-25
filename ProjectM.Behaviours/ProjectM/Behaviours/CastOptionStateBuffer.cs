// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.CastOptionStateBuffer
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
  public struct CastOptionStateBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    [FieldOffset(0)]
    public GenericEnemyState State;
    [FieldOffset(4)]
    public Entity Entity;

    static CastOptionStateBuffer()
    {
      Il2CppClassPointerStore<CastOptionStateBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (CastOptionStateBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionStateBuffer>.NativeClassPtr);
      CastOptionStateBuffer.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionStateBuffer>.NativeClassPtr, nameof (State));
      CastOptionStateBuffer.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionStateBuffer>.NativeClassPtr, nameof (Entity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastOptionStateBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
