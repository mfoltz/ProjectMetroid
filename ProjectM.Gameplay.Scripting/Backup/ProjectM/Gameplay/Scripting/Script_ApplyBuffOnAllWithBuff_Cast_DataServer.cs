// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_ApplyBuffOnAllWithBuff_Cast_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_ApplyBuffOnAllWithBuff_Cast_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffRequired;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffToApply;
    [FieldOffset(0)]
    public float Radius;
    [FieldOffset(4)]
    public HitFilter HitFilter;
    [FieldOffset(8)]
    public PrefabGUID BuffRequired;
    [FieldOffset(12)]
    public PrefabGUID BuffToApply;

    static Script_ApplyBuffOnAllWithBuff_Cast_DataServer()
    {
      Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_ApplyBuffOnAllWithBuff_Cast_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast_DataServer>.NativeClassPtr);
      Script_ApplyBuffOnAllWithBuff_Cast_DataServer.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast_DataServer>.NativeClassPtr, nameof (Radius));
      Script_ApplyBuffOnAllWithBuff_Cast_DataServer.NativeFieldInfoPtr_HitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast_DataServer>.NativeClassPtr, nameof (HitFilter));
      Script_ApplyBuffOnAllWithBuff_Cast_DataServer.NativeFieldInfoPtr_BuffRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast_DataServer>.NativeClassPtr, nameof (BuffRequired));
      Script_ApplyBuffOnAllWithBuff_Cast_DataServer.NativeFieldInfoPtr_BuffToApply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast_DataServer>.NativeClassPtr, nameof (BuffToApply));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
