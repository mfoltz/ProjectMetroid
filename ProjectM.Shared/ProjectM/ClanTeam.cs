// Decompiled with JetBrains decompiler
// Type: ProjectM.ClanTeam
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ClanTeam
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Motto;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_TeamValue;
    [FieldOffset(0)]
    public FixedString64 Name;
    [FieldOffset(64)]
    public FixedString64 Motto;
    [FieldOffset(128)]
    public Il2CppSystem.Guid ClanGuid;
    [FieldOffset(144)]
    public int TeamValue;

    static ClanTeam()
    {
      Il2CppClassPointerStore<ClanTeam>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ClanTeam));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanTeam>.NativeClassPtr);
      ClanTeam.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanTeam>.NativeClassPtr, nameof (Name));
      ClanTeam.NativeFieldInfoPtr_Motto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanTeam>.NativeClassPtr, nameof (Motto));
      ClanTeam.NativeFieldInfoPtr_ClanGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanTeam>.NativeClassPtr, nameof (ClanGuid));
      ClanTeam.NativeFieldInfoPtr_TeamValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanTeam>.NativeClassPtr, nameof (TeamValue));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanTeam>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
