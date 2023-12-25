// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.CastOptionTieBreaker
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct CastOptionTieBreaker
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Source;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pick;
    [FieldOffset(0)]
    public CastOptionTieBreakerSource Source;
    [FieldOffset(4)]
    public CastOptionTieBreakerPick Pick;

    static CastOptionTieBreaker()
    {
      Il2CppClassPointerStore<CastOptionTieBreaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (CastOptionTieBreaker));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionTieBreaker>.NativeClassPtr);
      CastOptionTieBreaker.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionTieBreaker>.NativeClassPtr, nameof (Source));
      CastOptionTieBreaker.NativeFieldInfoPtr_Pick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionTieBreaker>.NativeClassPtr, nameof (Pick));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastOptionTieBreaker>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
