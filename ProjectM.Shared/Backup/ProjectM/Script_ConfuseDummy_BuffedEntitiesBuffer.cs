﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Script_ConfuseDummy_BuffedEntitiesBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_ConfuseDummy_BuffedEntitiesBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModId;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public ModificationId ModId;

    static Script_ConfuseDummy_BuffedEntitiesBuffer()
    {
      Il2CppClassPointerStore<Script_ConfuseDummy_BuffedEntitiesBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Script_ConfuseDummy_BuffedEntitiesBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ConfuseDummy_BuffedEntitiesBuffer>.NativeClassPtr);
      Script_ConfuseDummy_BuffedEntitiesBuffer.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ConfuseDummy_BuffedEntitiesBuffer>.NativeClassPtr, nameof (Entity));
      Script_ConfuseDummy_BuffedEntitiesBuffer.NativeFieldInfoPtr_ModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ConfuseDummy_BuffedEntitiesBuffer>.NativeClassPtr, nameof (ModId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_ConfuseDummy_BuffedEntitiesBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
