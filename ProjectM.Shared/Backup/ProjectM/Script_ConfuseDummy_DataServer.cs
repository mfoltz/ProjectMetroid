// Decompiled with JetBrains decompiler
// Type: ProjectM.Script_ConfuseDummy_DataServer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_ConfuseDummy_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InitialAggroRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyOnCreatorDestroyed;
    [FieldOffset(0)]
    public float InitialAggroRange;
    [FieldOffset(4)]
    public bool DestroyOnCreatorDestroyed;

    static Script_ConfuseDummy_DataServer()
    {
      Il2CppClassPointerStore<Script_ConfuseDummy_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Script_ConfuseDummy_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ConfuseDummy_DataServer>.NativeClassPtr);
      Script_ConfuseDummy_DataServer.NativeFieldInfoPtr_InitialAggroRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ConfuseDummy_DataServer>.NativeClassPtr, nameof (InitialAggroRange));
      Script_ConfuseDummy_DataServer.NativeFieldInfoPtr_DestroyOnCreatorDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ConfuseDummy_DataServer>.NativeClassPtr, nameof (DestroyOnCreatorDestroyed));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_ConfuseDummy_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
